   M S B A M L   `   `   `  ����E  Acalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:calculator
calculator  5   	       calculator.Matrices   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:calculator     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Matrices��5	   	   $	��450��6   $	��800��6'    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   $��Segoe UI Semibold)�5       � WindowStartupLocation$ CenterScreen=�5   	   
���������5      Z�  � 	Resources 5       �� 
TargetType �� Property �� Value   cmButton  borderbutton��%K  '��       &	  H     �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   .@�5      �� -   5        $��75��5      $
��Exit��6    $��2q�6?   #���  6K   
�������6w   �� 5      -   5        $��75��5      $��Simple Calc��6    $��2q�6K   #���  6W   
�������6�   5      5      .��5      �� ���	#FF534C4C	 �� CornerRadius$	 10��6$   ._�5   
   � 
 � ColumnDefinitions
 5      �� 5      $��5* �6#   �� 5      $��1* �6#    � RowDefinitions 5      �� 5       $��15 �6    �� 5!      $��* �6    �� 5"      $��15 �6    .+�5$      �� -   5         ��Name$
 Menu��5$   K    � ToolTip$ 	Option(s)��6    K� ZIndex$ 3��6)   $��20��6;   $��0��6Y   $
��Left=�6f   $��0q�6�   
�������$��10,0,0,0q�6�   ��6�   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ExitToApp=�6*   5&      �� 5'      -   5         ��Name$ matrix1��5'   )   $��0��6   $��1��6:   .+�5(      � -   5         �Name$ matrix1Grid��5(      $��0,0,0,15q�6,   5)      � 5*      -   5        $ matrix2Grid��5*      5+      5,      �� 5-      $��1��6   $��1��6)   .+�5.      �� -   5        $ 
dotProduct��5.      $��Dot Product��6-   6C   �� 5/      -   5        $ multiplyMatrix��5/      $��Multiply Matrix��61   6K   �� 50      $��0,15,0,0q�6   $W��QCurrently only square matrices are supported. Please enter number of rows/columns��6.   $��12(�6�   $
��Wrap=�6�   $��Segoe UI)�6�   �� 51      -	   5         ��Name$ noOfRows��51      $��50��6,   �� 52      -
   5        $ Reset��52      $��New Set of Matrices��6(   6F   53      54      55      57      