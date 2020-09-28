using Sudoks.Animations;
using Sudoks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Sudoks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    { 
        public bool IsBirthday { get; set; }
        public Canvas canvasDrop { get; set; }
        public bool TextBoxReadOnly { get; set; }
        public int LabelNegativ { get; set; }
        public int LabelPositiv { get; set; }
        private bool mapIsFull { get; set; }

        public bool threadStoper { get; set; }
        public bool KeyPressed { get; set; }
        public int Level { get; set; }
        public string falseNum { get; set; }
        
        public string[,] sudokuMapOld { get; set; }
        public string[,] sudokuMapNew { get; set; }
       
        public int[,] sudokuMap { get; set; }
        public TextBox[,] textBoxes { get; set; }

        public CancellationToken token { get; set; }

        public event EventHandler<double> MouseMove1;

        Task task;
        Task task2;
        public MainWindow()
        {

            InitializeComponent();

            TestButton.IsEnabled = false;
            TestButton.Visibility = Visibility.Hidden;

            createArray();
            AllTextBoxesDisable();

            IsBirthday = true;
        }

        public void createArray()
        {
            textBoxes = new TextBox[9, 9];

            var myGrid = SudokuGrid;

            int countColumn = 1;
            int rowCount = 0;
            int row = 1;
            int column = 0;

            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                rowCount++;

                if (rowCount == 4 || rowCount == 8)
                {
                    rowCount++;
                    row += 2;
                }
                else
                {
                    row++;
                }

                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {


                    if (countColumn == 4 || countColumn == 8)
                    {
                        countColumn++;
                        column += 2;
                    }
                    else
                    {
                        column++;
                    }

                    textBoxes[i, j] = (TextBox)GetGridElement(myGrid, row, column);
                    textBoxes[i, j].Text = "";
                    textBoxes[i, j].IsEnabled = true;

                    countColumn++;
                }
                countColumn = 1;
                column = 0;
            }

        }
        private void array(object sender, EventArgs e)
        {
            textBoxes = new TextBox[9, 9];

            var myGrid = SudokuGrid;

            int countColumn = 1;
            int rowCount = 0;

            int row = 1;
            int column = 0;

            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                rowCount++;

                if (rowCount == 4 || rowCount == 8)
                {
                    rowCount ++;
                    row += 2;
                }
                else
                {
                    row++;
                }

                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    

                    if (countColumn == 4 || countColumn == 8)
                    {
                        countColumn++;
                        column += 2;
                    }
                    else
                    {
                        column++;
                    }                                      

                    textBoxes[i, j] = (TextBox)GetGridElement(myGrid, row, column);

                    countColumn++;
                }
                countColumn = 1;
                column = 0;
            }

        }
        public UIElement GetGridElement(Grid g, int r, int c)
        {
            for (int i = 0; i < g.Children.Count; i++)
            {
                UIElement e = g.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }
        Random random = new Random();
        private async void RefreshClick(object sender, RoutedEventArgs e)
        {

            labelPositiveCount.Content = "";
            labelNegativeCount.Content = "";

            LabelPositiv = 0;
            LabelNegativ = 0;
            TextBoxReadOnly = true;

            sudokuMapOld = new string[9,9];
            sudokuMapNew = new string[9, 9];

            RefreshButton.IsEnabled = false;
            RefreshButton.Visibility = Visibility.Hidden;

            ChangeLevelButton.IsEnabled = false;
            ChangeLevelButton.Visibility = Visibility.Hidden;

            TestButton.IsEnabled = false;
            TestButton.Visibility = Visibility.Hidden;


            sudokuMap = new int[9, 9];

            RandomArray randomArray = new RandomArray();
           

            MapGenerator mapGenerator = new MapGenerator();

            DispatcherTimer timerWhileProcesing = new DispatcherTimer();

            timerWhileProcesing.Interval = TimeSpan.FromMilliseconds(10);
            timerWhileProcesing.Tick += timerWhileProcesing_Tick;

            timerWhileProcesing.Start();

            sudokuMap = await Task.Run(() => mapGenerator.SudokuMapBuilder());

            timerWhileProcesing.Stop();

            DisplayOutput displayOutput = new DisplayOutput();

            if (task != null)
            await task;

            task2 = Task.Run(() => {

                EmptyAllTextBoxes();
                
                displayOutput.ShowStartMap( randomArray.randomArray(Level), textBoxes,sudokuMap );
            });


            await task2;


            ChangeLevelButton.IsEnabled = true;
            ChangeLevelButton.Visibility = Visibility.Visible;


            if(checkBoxHelp.IsChecked == false)
            {
                TestButton.IsEnabled = true;
                TestButton.Visibility = Visibility.Visible;
            }
          

            RefreshButton.IsEnabled = true;
            RefreshButton.Visibility = Visibility.Visible;
            RefreshButton.Content = "Refresh";


        }

      
        private void timerWhileProcesing_Tick(object sender, EventArgs e)
        {
            ShowFakeProcesing();
        }
               
        Random randomA = new Random();
        private void ShowFakeProcesing()
        {

            createArray();

            sudokuMap = new int[9, 9];

            int num = 0;

            string[] randomArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "", "" };
            task = Task.Run(() => {


                 for (int i = 0; i < textBoxes.GetLength(0); i++)
                 {
                     for (int j = 0; j < textBoxes.GetLength(1); j++)
                     {
                        Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.White);
                        Dispatcher.Invoke(() => textBoxes[i, j].Opacity = 0.94);
                         num = randomA.Next(1, 11);

                         Dispatcher.Invoke(() => textBoxes[i, j].Text = randomArray[num]);
                     }
                 }
             }, token);
            
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^1-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void Test(object sender, RoutedEventArgs e)
        {
            falseNum = "";

            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    if (textBoxes[i, j].Text != "" && textBoxes[i, j].Text != sudokuMap[i, j].ToString())
                    {
                        falseNum = textBoxes[i, j].Text;
                        break;
                    }
                }
            }
            if(falseNum != "")
            {
                new Thread(() =>
                {
                    for (int a = 0; a < textBoxes.GetLength(0); a++)
                    {
                        for (int b = 0; b < textBoxes.GetLength(1); b++)
                        {
                            if (Dispatcher.Invoke(() => textBoxes[a, b].Text == falseNum && textBoxes[a, b].Text != ""))
                            {
                                Dispatcher.Invoke(() => textBoxes[a, b].Foreground = Brushes.Red);

                            }
                        }
                    }
                    Thread.Sleep(1500);

                    for (int a = 0; a < textBoxes.GetLength(0); a++)
                    {
                        for (int b = 0; b < textBoxes.GetLength(1); b++)
                        {
                            if (Dispatcher.Invoke(() => textBoxes[a, b].Text == falseNum && textBoxes[a, b].Text != ""))
                            {
                                Dispatcher.Invoke(() => textBoxes[a, b].Foreground = Brushes.Black);

                            }
                        }
                    }

                }).Start();
            }
            else if (falseNum == "")
            {
                var ok = Task.Run(() =>
                 {
                     Dispatcher.Invoke(() => Canvas.SetZIndex(label, 1));
                     Dispatcher.Invoke(() => label.Content = "Ok!");
                     Dispatcher.Invoke(() => label.Visibility = Visibility.Visible);

                     for (int i = 0; i < 50; i++)
                     {
                         Dispatcher.Invoke(() => label.Opacity -= 0.01);
                         Thread.Sleep(20);

                     }

                 });

                await ok;
                Canvas.SetZIndex(label, -1);
                label.Content = "";
                Dispatcher.Invoke(() => label.Visibility = Visibility.Hidden);
                label.ClearValue(UIElement.OpacityProperty);
            }


        }
        private void textChange(object sender, TextChangedEventArgs e)
        {
             mapIsFull = true;
            TextBox textBox = sender as TextBox;

            if (ChangeLevelButton.IsEnabled)
            {

                if (textBox.IsReadOnly == false) TextBoxReadOnly = false;


                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {

                        if (textBoxes[i, j].Text != sudokuMap[i, j].ToString())
                        {
                            mapIsFull = false;
                        }
                    }
                }

                if (mapIsFull)
                {
                    RefreshButton.IsEnabled = false;
                    RefreshButton.Visibility = Visibility.Hidden;

                    ChangeLevelButton.IsEnabled = false;
                    ChangeLevelButton.Visibility = Visibility.Hidden;

                    TestButton.IsEnabled = false;
                    TestButton.Visibility = Visibility.Hidden;


                    for (int i = 0; i < textBoxes.GetLength(0); i++)
                    {
                        for (int j = 0; j < textBoxes.GetLength(1); j++)
                        {
                            Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.Bold);
                            Dispatcher.Invoke(() => textBoxes[i, j].Foreground = Brushes.Black);
                            Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.White);

                        }
                    }

                    Animations.Win win = new Animations.Win();

                    for (int i = 0; i < textBoxes.GetLength(0); i++)
                    {
                        for (int j = 0; j < textBoxes.GetLength(1); j++)
                        {
                            textBoxes[i, j].Foreground = Brushes.Black;
                            if (textBoxes[i, j].Text == sudokuMap[i, j].ToString() && textBoxes[i, j] == sender)
                            {
                                Task.Run(() =>
                                {

                                    for (int a = 0; a < 15; a++)
                                    {
                                        win.Animate(random.Next(2, 10), random.Next(2, 10), random.Next(1, 10), textBoxes, SudokuGrid);

                                    }


                                    for (int a = 0; a < textBoxes.GetLength(0); a++)
                                    {
                                        for (int b = 0; b < textBoxes.GetLength(1); b++)
                                        {
                                            Dispatcher.Invoke(() => textBoxes[a, b].IsEnabled = false);

                                            Thread.Sleep(40);

                                        }
                                    }

                                    win.Animate(70, 6, 7, 5, 3, 30, textBoxes, SudokuGrid);
                                    Thread.Sleep(3000);

                                    Dispatcher.Invoke(() => ChangeLevelButton.IsEnabled = true);
                                    Dispatcher.Invoke(() => ChangeLevelButton.Visibility = Visibility.Visible);

                                    if(Dispatcher.Invoke(()=>checkBoxHelp.IsChecked == false))
                                    {
                                        Dispatcher.Invoke(() => TestButton.IsEnabled = true);
                                        Dispatcher.Invoke(() => TestButton.Visibility = Visibility.Visible);
                                    }
                                  

                                    Dispatcher.Invoke(() => RefreshButton.IsEnabled = true);
                                    Dispatcher.Invoke(() => RefreshButton.Visibility = Visibility.Visible);
                                    Dispatcher.Invoke(() => RefreshButton.Content = "Refresh");
                                });
                            }
                        }
                    }


                }
                mapIsFull = true;
            }

                      
        }

       
        public void EmptyAllTextBoxes()
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {

                    Dispatcher.Invoke(() => textBoxes[i, j].Text = "");
                    Dispatcher.Invoke(() => textBoxes[i, j].IsEnabled = true);
                    Dispatcher.Invoke(() => textBoxes[i, j].IsReadOnly = false);
                    Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.White);

                }
            }
        }
        public void AllTextBoxesDisable()
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {

                    textBoxes[i, j].IsEnabled = false;

                }
            }
        }
     
        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            threadStoper = true;

            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {

                   if(textBoxes[i, j] == sender && !textBoxes[i, j].IsReadOnly && textBoxes[i, j].Text != sudokuMap[i, j].ToString())
                    {

                        textBoxes[i, j].Text = "";
                        textBoxes[i, j].Background = Brushes.White;
                        textBoxes[i, j].Foreground = Brushes.Black;
                        textBoxes[i, j].FontSize = 25;
                        textBoxes[i, j].FontWeight = FontWeights.Bold;

                    }
                    else
                    {
                       
                        textBoxes[i, j].Background = Brushes.White;
                        textBoxes[i, j].Foreground = Brushes.Black;
                        textBoxes[i, j].FontSize = 25;
                        textBoxes[i, j].FontWeight = FontWeights.Bold;
                    }
                    Dispatcher.Invoke(()=> textBoxes[i, j].Opacity = 1);
                   
                }
            }
         

            if(e != null)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Animations.AnimateCellClick animateCellClick = new Animations.AnimateCellClick();
                    animateCellClick.AnimateKeyUp(ChangeLevelButton.IsEnabled, sender, textBoxes);
                }
            }
          

        }

        private  void LevelButton_Click(object sender, RoutedEventArgs e)
        {
            if (REasy.IsChecked == true) Level = 45;
            if (RNormal.IsChecked == true) Level = 28;
            if (RHard.IsChecked == true) Level = 14;


            Animations.Menu menu = new Animations.Menu();

            RotateTransform rotateTransform = new RotateTransform();

            double countBottom = 0;


            RefreshButton.Visibility = Visibility.Hidden;
            ChangeLevelButton.Visibility = Visibility.Hidden;
            

            canvasDrop = new Canvas();
            Grid.SetColumnSpan(canvasDrop, 13);
            Grid.SetRowSpan(canvasDrop, 16);
            SudokuGrid.Children.Add(canvasDrop);

            Canvas canvasDrop2 = new Canvas();
            Grid.SetColumnSpan(canvasDrop2, 13);
            Grid.SetRowSpan(canvasDrop2, 16);
            SudokuGrid.Children.Add(canvasDrop2);
          
            DateTime dateTime = DateTime.Now;

            Image imageBox = new Image();

            Task.Run(() =>
            {
                while (countBottom > -485)
                {

                    Thread.Sleep(2);

                    Dispatcher.Invoke(() => menu.MenuHide(SudokuGrid, panel, menuCanvas, countBottom));
                    Dispatcher.Invoke(() => panel.Visibility = Visibility.Visible);
                    Dispatcher.Invoke(() => panel.IsEnabled = true);

                    countBottom -= 5;


                    if (countBottom == -200)
                    {
                        Dispatcher.Invoke(() => RefreshButton.Visibility = Visibility.Visible);
                        Dispatcher.Invoke(() => ChangeLevelButton.Visibility = Visibility.Visible);
                    }

                }

                MenuPanelWrapingAfectedControls();
                IsBirthday = false;
            });

        }

        private void MenuPanelWrapingAfectedControls()
        {

            if (Dispatcher.Invoke(() => checkBoxHelp.IsChecked == false))
            {
                Dispatcher.Invoke(() => labelPositiveCount.Visibility = Visibility.Hidden);
                Dispatcher.Invoke(() => labelNegativeCount.Visibility = Visibility.Hidden);
                Dispatcher.Invoke(() => labelPositiveCount.IsEnabled = false);
                Dispatcher.Invoke(() => labelNegativeCount.IsEnabled = false);
                Dispatcher.Invoke(() => TestButton.IsEnabled = true);
                Dispatcher.Invoke(() => TestButton.Visibility = Visibility.Visible);
            }
            else
            {
                Dispatcher.Invoke(() => labelPositiveCount.Visibility = Visibility.Visible);
                Dispatcher.Invoke(() => labelNegativeCount.Visibility = Visibility.Visible);
                Dispatcher.Invoke(() => labelPositiveCount.IsEnabled = true);
                Dispatcher.Invoke(() => labelNegativeCount.IsEnabled = true);
                Dispatcher.Invoke(() => TestButton.IsEnabled = false);
                Dispatcher.Invoke(() => TestButton.Visibility = Visibility.Hidden);
            }

            Dispatcher.Invoke(() => panel.Visibility = Visibility.Hidden);
            Dispatcher.Invoke(() => panel.IsEnabled = false);
        }
        private async void ChangeLevelButton_Click(object sender, RoutedEventArgs e)
        {

            Animations.Menu menu = new Animations.Menu();

            double countBottom = -485;

            ChangeLevelButton.IsEnabled = false;

            await Task.Run(() =>
            {
                Dispatcher.Invoke(() => panel.Visibility = Visibility.Visible);
                Dispatcher.Invoke(() => panel.IsEnabled = true);

                while (countBottom < 0)
                {


                    Thread.Sleep(3);

                    Dispatcher.Invoke(() => menu.MenuHide(SudokuGrid, panel, menuCanvas, countBottom));
                    Dispatcher.Invoke(() => panel.Visibility = Visibility.Visible);
                    Dispatcher.Invoke(() => panel.IsEnabled = true);


                    countBottom += 5;
                }
                Dispatcher.Invoke(() => ChangeLevelButton.IsEnabled = true);
            });

        }
             
        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ChangeLevelButton.IsEnabled && checkBoxHelp.IsChecked == true)
            {

                TextBox textBox = sender as TextBox;

                NumberColorsOnEnter numberColorsOnEnter = new NumberColorsOnEnter(textBoxes, textBox, sudokuMap);
              
            }
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ChangeLevelButton.IsEnabled && checkBoxHelp.IsChecked == true)
            {

                TextBox textBox = sender as TextBox;

                MapCleaner.Clean(textBoxes, textBox);
               
            }
        }
       
       
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ChangeLevelButton.IsEnabled)
            {

                TextBox textBox = sender as TextBox;


                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {

                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {

                        if (textBoxes[i, j] == textBox)
                        {
                            if (textBoxes[i, j].Text == sudokuMap[i, j].ToString())
                            {
                                if(!RowsOrColumnIsFull.CheckForVerticalMach(textBoxes, sudokuMap, j, textBox) && !RowsOrColumnIsFull.CheckForHorizontalMach(textBoxes, sudokuMap, i, textBox))
                                    textBoxes[i, j].IsReadOnly = false;
                                else
                                    textBoxes[i, j].IsReadOnly = true;
                            }
                            else
                            {
                                textBoxes[i, j].Text = "";
                                textBoxes[i, j].Text = textBox.Text;

                            }


                        }

                    }

                }

            }

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (ChangeLevelButton.IsEnabled && e.Key == Key.Right || ChangeLevelButton.IsEnabled && e.Key == Key.Left ||
                ChangeLevelButton.IsEnabled && e.Key == Key.Down || ChangeLevelButton.IsEnabled && e.Key == Key.Up)
            {
                KeyPressed = true;
                TextBox textBox = sender as TextBox;

                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {

                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {

                        if (textBoxes[i, j] == textBox)
                        {
                            if (e.Key == Key.Right)
                            {

                                if (j + 1 < 9)
                                {
                                  
                                    TextBox_PreviewMouseDown(textBoxes[i, ++j], null);
                                    Keyboard.Focus(textBoxes[i, j]);
                                    return;

                                }


                            }
                            if (e.Key == Key.Left)
                            {
                                if (j - 1 > -1)
                                {
                                  
                                    TextBox_PreviewMouseDown(textBoxes[i, --j], null);
                                    Keyboard.Focus(textBoxes[i, j]);
                                    return;

                                }

                            }
                            if (e.Key == Key.Down)
                            {
                                if (i + 1 < 9)
                                {
                             
                                    TextBox_PreviewMouseDown(textBoxes[++i, j], null);
                                    Keyboard.Focus(textBoxes[i, j]);
                                    return;

                                }

                            }
                            if (e.Key == Key.Up)
                            {
                                if (i - 1 > -1)
                                {
                                  
                                    TextBox_PreviewMouseDown(textBoxes[--i, j], null);
                                    Keyboard.Focus(textBoxes[i, j]);
                                    return;

                                }


                            }
                        }

                    }

                }
                KeyPressed = false;
            }
        }

        private void TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
                           


            if (ChangeLevelButton.IsEnabled)
            {




                TextBox textBox = sender as TextBox;

                MapCleaner.Clean(textBoxes, textBox);
              

                if (e.Key != Key.Right && e.Key != Key.Left &&
                 e.Key != Key.Down && e.Key != Key.Up && checkBoxHelp.IsChecked == true)
                {
                    bool corect = false;
                  
                    for (int i = 0; i < textBoxes.GetLength(0); i++)
                    {

                        for (int j = 0; j < textBoxes.GetLength(1); j++)
                        {
                            if (textBoxes[i, j].Text == textBox.Text)
                            {

                                if (textBoxes[i, j].Text != sudokuMap[i, j].ToString() && textBoxes[i, j].Text != "")
                                {

                                    Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.Crimson);
                                    Dispatcher.Invoke(() => textBoxes[i, j].Foreground = Brushes.White);
                                    Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.ExtraBlack);

                                }

                                else if (textBoxes[i, j].Text == sudokuMap[i, j].ToString())
                                {
                                    Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.SeaGreen);
                                    Dispatcher.Invoke(() => textBoxes[i, j].Foreground = Brushes.White);
                                    Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.ExtraBlack);
                                    corect = true;
                                }



                                if (textBoxes[i, j] == textBox)
                                {

                                    RowAndColumnColourHolder rowAndColumnColourHolder = new RowAndColumnColourHolder();

                                    Animations.FullLine fullLine = new Animations.FullLine();

                                    if (RowsOrColumnIsFull.CheckForVerticalMach(textBoxes, sudokuMap, j, textBox) && RowsOrColumnIsFull.CheckForHorizontalMach(textBoxes, sudokuMap, i, textBox) && textBoxes[i, j].IsReadOnly == false)
                                    {
                                        textBoxes[i, j].IsReadOnly = true;

                                        rowAndColumnColourHolder.AddColumn(textBoxes, j);
                                        rowAndColumnColourHolder.AddRow(textBoxes, i);

                                        Parallel.Invoke(() =>
                                        {
                                            fullLine.AnimateVertical(textBoxes, j, rowAndColumnColourHolder.GetColumn());

                                        }, () =>
                                        {

                                            fullLine.AnimateHorizontal(textBoxes, i, rowAndColumnColourHolder.GetRow());
                                        });

                                    }
                                    if (RowsOrColumnIsFull.CheckForVerticalMach(textBoxes, sudokuMap, j, textBox) && textBoxes[i, j].IsReadOnly == false)
                                    {
                                        textBoxes[i, j].IsReadOnly = true;
                                        rowAndColumnColourHolder.AddColumn(textBoxes, j);
                                        Dispatcher.Invoke(() => fullLine.AnimateVertical(textBoxes, j, rowAndColumnColourHolder.GetColumn()));

                                    }
                                    else if (RowsOrColumnIsFull.CheckForHorizontalMach(textBoxes, sudokuMap, i, textBox) && textBoxes[i, j].IsReadOnly == false)
                                    {
                                        textBoxes[i, j].IsReadOnly = true;
                                        rowAndColumnColourHolder.AddRow(textBoxes, i);
                                        fullLine.AnimateHorizontal(textBoxes, i, rowAndColumnColourHolder.GetRow());
                                    }
                                }

                              
                            }
                            if (corect) textBoxes[i, j].IsReadOnly = true;

                            corect = false;
                        }
                    }

                    Animations.CountMoves countMoves = new Animations.CountMoves();

                    if(textBox.IsReadOnly == true && TextBoxReadOnly == false)
                    {
                        LabelPositiv++;
                        TextBoxReadOnly = true;
                        countMoves.Animate(labelPositiveCount, LabelPositiv);
                    }
                    else if(textBox.IsReadOnly == false && textBox.Text !="")
                    {
                        LabelNegativ++;
                        countMoves.Animate(labelNegativeCount, LabelNegativ);
                    }

                }
                else
                {
                    KeyPressed = true;

                    Animations.AnimateCellClick animateCellClick = new Animations.AnimateCellClick();

                    animateCellClick.AnimateKeyUp(ChangeLevelButton.IsEnabled, sender, textBoxes);

                    KeyPressed = false;

                    if(checkBoxHelp.IsChecked == true)
                    {
                        NumberColorsOnEnter numberColorsOnEnter = new NumberColorsOnEnter(textBoxes, textBox, sudokuMap);

                       
                    }
                    
                   
                }
                
                                             
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

    }
}
