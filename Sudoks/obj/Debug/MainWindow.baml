   M S B A M L   `   `   `  ����A  =Sudoks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SudoksSudoks  5   	       Sudoks.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Sudoks     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Sudoku��5	   	   $��
ExtraBlack"�6   $	��485��60   $	��442��6=    � Cursor$ Arrow��6I   
���   �.��5      � -   5        $��
SudokuGrid��5      ��5   
   �� 5       �� ImageSource$4 ./Images/mathijs-delva-qUsXjo_d4lU-unsplash.jpg��6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��9 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��9 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��20 �6    � RowDefinitions 5"   
   �� 5$      $��20 �6   �� 5%      $��35 �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��9 �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��9 �6   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   �� 51      $��20 �6   �� 52      $��* �6   �� 53      $��25 �6   .+�5:   
   �� -   5        $��2��5:      $��1��6    $��Stretch=�60    �� TextWrapping$
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�    �� 	MaxLength$ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5;   
   -   5        $��2��5;      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5<   
   -   5        $��2��5<      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5=   
   -   5        $��2��5=      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5>   
   -   5        $��2��5>      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5?   
   -   5        $��2��5?      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5@   
   -	   5        $��2��5@      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5A   
   -
   5        $��2��5A      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5B   
   -   5        $��2��5B      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5D   
   -   5        $��3��5D      $��1��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5E   
   -   5        $��3��5E      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5F   
   -   5        $��3��5F      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5G   
   -   5        $��3��5G      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5H   
   -   5        $��3��5H      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5I   
   -   5        $��3��5I      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5J   
   -   5        $��3��5J      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5K   
   -   5        $��3��5K      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5L   
   -   5        $��3��5L      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5N   
   -   5        $��4��5N      $��1��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5O   
   -   5        $��4��5O      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5P   
   -   5        $��4��5P      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5Q   
   -   5        $��4��5Q      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5R   
   -   5        $��4��5R      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5S   
   -   5        $��4��5S      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5T   
   -   5        $��4��5T      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5U   
   -   5        $��4��5U      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5V   
   -   5        $��4��5V      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5Z   
   -   5        $��6��5Z      $��1��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5[   
   -   5        $��6��5[      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5\   
   -    5        $��6��5\      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5]   
   -!   5        $��6��5]      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5^   
   -"   5        $��6��5^      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5_   
   -#   5        $��6��5_      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5`   
   -$   5        $��6��5`      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5a   
   -%   5        $��6��5a      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5b   
   -&   5        $��6��5b      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5d   
   -'   5        $��7��5d      $��1��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5e   
   -(   5        $��7��5e      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5f   
   -)   5        $��7��5f      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5g   
   -*   5        $��7��5g      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5h   
   -+   5        $��7��5h      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5i   
   -,   5        $��7��5i      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5j   
   --   5        $��7��5j      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5k   
   -.   5        $��7��5k      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5l   
   -/   5        $��7��5l      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5n   
   -0   5        $��8��5n      $��1��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5o   
   -1   5        $��8��5o      $��2��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5p   
   -2   5        $��8��5p      $��3��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5q   
   -3   5        $��8��5q      $��5��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5r   
   -4   5        $��8��5r      $��6��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5s   
   -5   5        $��8��5s      $��7��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5t   
   -6   5        $��8��5t      $��9��6    $��Stretch=�60   $
 Wrap=�6O   $��Stretch=�6d   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6$  �� 5u   
   -7   5        $��8��5u      $��10��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5v   
   -8   5        $��8��5v      $��11��6    $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5y   
   -9   5        $��10��5y      $��1��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5z   
   -:   5        $��10��5z      $��2��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5{   
   -;   5        $��10��5{      $��3��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5|   
   -<   5        $��10��5|      $��5��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5}   
   -=   5        $��10��5}      $��6��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5~   
   ->   5        $��10��5~      $��7��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5   
   -?   5        $��10��5      $��9��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -@   5        $��10��5�      $��10��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -A   5        $��10��5�      $��11��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -B   5        $��11��5�      $��1��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -C   5        $��11��5�      $��2��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -D   5        $��11��5�      $��3��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -E   5        $��11��5�      $��5��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -F   5        $��11��5�      $��6��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -G   5        $��11��5�      $��7��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -H   5        $��11��5�      $��9��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -I   5        $��11��5�      $��10��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -J   5        $��11��5�      $��11��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -K   5        $��12��5�      $��1��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -L   5        $��12��5�      $��2��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -M   5        $��12��5�      $��3��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -N   5        $��12��5�      $��5��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -O   5        $��12��5�      $��6��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -P   5        $��12��5�      $��7��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -Q   5        $��12��5�      $��9��6!   $��Stretch=�61   $
 Wrap=�6P   $��Stretch=�6e   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6%  �� 5�   
   -R   5        $��12��5�      $��10��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -S   5        $��12��5�      $��11��6!   $��Stretch=�62   $
 Wrap=�6Q   $��Stretch=�6f   $��Center=�6�   $��25(�6�   $
��Bold"�6�   $ 1��6�   $
 Hand��6�  $��Center=�6  $��-1q�6&  �� 5�   
   -T   5         ��Name$ ChangeLevelButton��5�      $��3��6-   $��Level��6A   $��1��6Q   $��23��6a   $��90��6m   $��Center=�6x   $��14��6�   $��Center=�6�   $��jazzy)�6�   $��17(�6�   $��Black"�6�   $
 Hand��6  	 � 	Resources	 5�      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5�      "
 ��6   .�5�      ��  �@��CornerRadius$ 7��65   5�      5�       � Triggers 5�      :� 5�       :� RoutedEvent$ Button.MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W�  �� 
TargetName$ ChangeLevelButton��6.    �� TargetProperty$ Width�5�       W� From$ 90X�5�      	 W� To$	 100X�6    g� Duration$ 0:0:0.5D�6&   W� 5�      $ ChangeLevelButton��6.   $ Height�5�      $ 23X�5�      $ 28X�6   $ 0:0:0.5D�6%   5�      5�      5�      :� 5�      $ Button.MouseLeave��6   .[�5�      �� .��5�      �� .��5�      W� $ ChangeLevelButton��6.   $ Width�5�      $	 100X�5�      $ 90X�6   $ 0:0:0.5D�6&   W� 5�      $ ChangeLevelButton��6.   $ Height�5�      $ 28X�5�      $ 23X�6   $ 0:0:0.5D�6%   5�      5�      5�      5�      �� 5�   
   -U   5        $ 
TestButton��5�      $��3��6&   $
��Test��6:   $��9��6I   $��23��6Y   $��90��6e   $��Center=�6p   $��14��6�   $��Center=�6�   $��jazzy)�6�   $��17(�6�   $��Black"�6�   $
 Hand��6�   	 5�      ��%^   '��       �� 5�      "
 ��6   .�5�      ��  �@��CornerRadius$ 7��65   5�      5�       5�      :� 5�      $ Button.MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W� $ 
TestButton��6.   $ Width�5�      $ 90X�5�      $	 100X�6   $ 0:0:0.5D�6&   W� 5�      $ 
TestButton��6.   $ Height�5�      $ 23X�5�      $ 28X�6   $ 0:0:0.5D�6%   5�      5�      5�      :� 5�      $ Button.MouseLeave��6   .[�5�      �� .��5�      �� .��5�      W� $ 
TestButton��6.   $ Width�5�      $	 100X�5�      $ 90X�6   $ 0:0:0.5D�6&   W� 5�      $ 
TestButton��6.   $ Height�5�      $ 28X�5�      $ 23X�6   $ 0:0:0.5D�6%   5�      5�      5�      5�      �� 5�   
   -V   5        $ RefreshButton��5�      $��3��6(   $��Refresh��6<   $��5��6N   $��25��6^   $	��100��6j   $��Center=�6v   $��14��6�   $��Center=�6�   $��jazzy)�6�   $��18(�6�   $��Black"�6�   $
 Hand��6  	 5�      ��%^   '��       �� 5�      "
 ��6   .�5�      ��  �@��CornerRadius$ 7��65   5�      5�       5�      :� 5�      $ Button.MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W� $ RefreshButton��6.   $ Width�5�      $	 100X�5�      $	 110X�6   $ 0:0:0.5D�6'   W� 5�      $ RefreshButton��6.   $ Height�5�      $ 25X�5�      $ 30X�6   $ 0:0:0.5D�6%   5�      5�      5      :� 5     $ Button.MouseLeave��6   .[�5     �� .��5     �� .��5     W� $ RefreshButton��6.   $ Width�5     $	 110X�5     $	 100X�6   $ 0:0:0.5D�6'   W� 5     $ RefreshButton��6.   $ Height�5	     $ 30X�5
     $ 25X�6   $ 0:0:0.5D�6%   5     5     5     5     �� 5  
   -W   5         ��Name$ label��5     $y�Hidden=�6   $��5��63   $��5��6G   $��6��6W   $��4��6d   
���   �$��Ok��6�   $��jazzy)�6�   $��70(�6�   $��Black"�6�   {�.   K� ZIndex$ -2��6�   �� 5  
   -X   5        $ labelPositiveCount��5     $��Center=�6-   $��Center=�6H   $��3��6e   $��4��6y   $��0��6�   $��2��6�   
�������$��jazzy)�6�   $��25(�6�   $
��Bold"�6�   {�.  6�   �� 5  
   -Y   5        $ 	labelDots��5     $��Center=�6$   $��Center=�6?   $��1��6\   $��6��6p   $��0��6�   $��2��6�   
���   �$��:��6�   $��jazzy)�6�   $��30(�6�   $��Black"�6�   {�.  6�   �� 5  
   -Z   5        $ labelNegativeCount��5     $��Center=�6-   $��Center=�6H   $��3��6e   $��6��6y   $��0��6�   $��2��6�   
���<��$��jazzy)�6�   $��25(�6�   $
��Bold"�6�   {�.  6�   �� 5  
   -[   5         ��Name$ 
menuCanvas��5     $��13��6%   $��16��6:   �� 5  
   -\   5        $��panel��5     $��13��6"   $��16��67   $ 4��6I   $��Stretch=�6Z   $	��Top=�6x   ��5     �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5!     �  � Color$ Black��6#    � Offset$ 1Q�61   � 5"     $ 	#FF88CD61��6#   � 5#     $ 	#FFAFC1A5��6#   $ 0.853Q�65   � 5$     $ 	#FF19320C��6#   $ 1Q�65   5%     .+�5'     � -]   5         �Name$ 	PanelGrid��5'     $��0��6&   $��0��63   $��13��6C   $��14��6X   $	��475��6j   $	��442��6w    5(     �� 5)     $��20 �6'   �� 5*     $��* �6'   �� 5+     $��* �6'   �� 5,     $��* �6'   �� 5-     $��* �6'   �� 5.     $��* �6'   �� 5/     $��* �6'   �� 50     $��* �6'   �� 51     $��20 �6'    54     �� 55     $��20 �6$   �� 56     $��* �6$   �� 57     $��* �6$   �� 58     $��* �6$   �� 59     $��* �6$   �� 5:     $��* �6$   �� 5;     $��* �6$   �� 5<     $��* �6$   �� 5=     $��* �6$   �� 5>     $��* �6$   �� 5?     $��10 �6$   .+�5B     �� -^   5        $ 
PanelLabel��5B     $��3��6,   $��3��6@   $��2��6P   $��1��6]   
���   �$��Līmenis��6�   $��jazzy)�6�   $��43(�6�   $��Black"�6�   {�.  $ 2��6�   ��6�   Z� �� 5D     $��0q�6   $��0q�6'   $��2��63   $��1��6C   $��3��6W   $��3��6d   $y�Visible=�6u   $��0q�6�   .��5E     � -_   5        $ GroupBoxGrid��5E     $��3��62   $��3��6F    5F     �� 5H     $��* �6/    5L     �� 5N     $��* �6,   �� 5O     $��* �6,   �� 5P     $��* �6,   .+�5T     	� -`   5         	�Name$ radioButtonLupatiņa��5T  &   $��2��6D   $��Center=�6T   $��0��6r   $��Center=�6   $
 Hand��6�   	� 5U     -a   5        $ radioButtonStandartņiks��5U  &   $��2��6H   $��Center=�6X   $��1��6v   $��Center=�6�    d� 	IsChecked$
 TrueY�6�   $
 Hand��6�   	� 5V     -b   5        $ radioButtonBotaņiks��5V  &   $��2��6D   $��Center=�6T   $��2��6r   $��Center=�6   $
 Hand��6�   �� 5W     5Y     5Z     5[     �� 5]     -c   5        $ 	Lupatiņa��5]     $��3��6*   $��3��6>   $��3��6N   $��1��6[   
�������$��	Lupatiņa��6�   $��jazzy)�6�   $��30(�6�   $��Black"�6�   {�.  $ 2��6�   ��6�   Z� �� 5^     -d   5        $ Standartņiks��5^     $��4��6.   $��3��6B   $��4��6R   $��1��6_   
��� � �$��Standartņiks��6�   $��jazzy)�6�   $��30(�6�   $��Black"�6�   {�.  $ 2��6�   ��6�   Z� �� 5_     -e   5        $ 	Botaņiks��5_     $��3��6*   $��3��6>   $��5��6N   $��1��6[   
���� ��$��	Botaņiks��6�   $��jazzy)�6�   $��30(�6�   $��Black"�6�   {�.  $ 2��6�   ��6�   Z� �� 5a     -f   5        $ LevelButton��5a     $��3��6.   $��Ok��6B   $��jazzy)�6O   $	��100��6b   $��35��6n   $��20(�6z   $��Black"�6�   $��3��6�   $��Stretch=�6�   $��7��6�   $��Center=�6�   $
 Hand��6  	 5b     ��%_   '��       �� 5c     "
 ��6    .�5d     ��  �@��CornerRadius$ 20��6=   5e     5f      5h     :� 5k     $ Button.MouseEnter��6'   .[�5l     �� .��5m  "   �� .��5n  &   W� $ LevelButton��66   $ Width�5o     $	 100X�5p     $	 130X�6   $ 0:0:1D�6'   W� 5q  &   $ LevelButton��66   $ Height�5r     $ 35X�5s     $ 41X�6   $ 0:0:1D�6%   5t  #   5v     5w     :� 5y     $ Button.MouseLeave��6'   .[�5z     �� .��5{  "   �� .��5|  &   W� $ LevelButton��66   $ Width�5}     $	 130X�5~     $	 100X�6   $ 0:0:1D�6'   W� 5  &   $ LevelButton��66   $ Height�5�     $ 41X�5�     $ 35X�6   $ 0:0:1D�6%   5�  #   5�     5�     5�     �� 5�     -g   5         ��Name$ checkBoxHelp��5�     $
 TrueY�61   $��2��6B   $��Center=�6R   $��6��6p   $��Center=�6}   $
 Hand��6�   �� 5�     -h   5        $ 	labelHelp��5�     $��3��6+   $��3��6?   $��6��6O   $��1��6\   ���	#FF3E7499$��Palīdzība��6�   $��jazzy)�6�   $��25(�6�   $��DemiBold"�6�   {�.  $ 2��6�   ��6�   Z� 5�     5�     �� 5�  
   -i   5        $ myCanvas��5�     $��13��6#   $��16��68   �� 5�  
   -j   5        $ secondCanvas��5�     $��13��6'   $��16��6<   �� 5�  
   -k   5        $ DzimsanasDienaCanvas��5�     $��13��6/   $��16��6D   5�     5�     