   M S B A M L   `   `   `  ����U  QManagementPanelProject.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ManagementPanelProject.WPF.ViewManagementPanelProject.WPF.View  5   	   2    ,ManagementPanelProject.WPF.View.StandardView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ManagementPanelProject.WPF.View     5   	   -   5          � Title$  
User Panel��5   
   $	��450��6   $	��800��6*    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #462AD8��6#   
 � Offset$
 0Q�63   � 5      $	 #DA34AE��6#   $

 0.75Q�63   � 5      $	 #8A16C1��6#   $
 1Q�63   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $	 #060531��6#   $
 0Q�63   � 5      $	 #1B1448��6#   $
 1Q�63   5       ._�5"      �  � RowDefinitions 5#      �� 5$      $��30 �6$   �� 5%      .+�5'      � $��0��6    � ColumnDefinitions 5)      �� 5*      �� 5+      $��25 �6+   �� 5,      $��25 �6+   �� 5-      $��5 �6+   .+�50      �� -   5         ��Name$ 	UserPanel��50       $��
USER PANEL��63   
�������$��10(�52       $��
Montserrat)�53       $��0��54       $��Center=�55       $��10,0,0,0q�56       �� 57      -   5         ��Name$ btnMinimize��57      $��0q�58      $��-��59      
�������$��16(�5;      $��
Montserrat)�5<       � Cursor$
 Hand��5=      $��1��5>      ��5A      �� 5B       �� 
TargetType" ��6$   .�5C   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5D   "   P� 5E   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5F   *   ��  � �� �#278BEF6G   5G   '   5I      ��5L      �� 5M       �� 
TargetType" ��6.   .R�5N   "   �� $��18��6)   $��18��64   $ 9��5O   )   #��z��5P   )   ._�5Q   &   �� $��Center=�67   $��Center=�5R   7   5S   #   5T      5W      �� 5Y      -   5        $ btnClose��5Y      $��0q�5Z      $��X��5[      
�������$��12(�5]      $��
Montserrat)�5^      $
 Hand��5_      $��2��5`      ��5c      �� 5d      " ��6$   .�5e   "   ��  � �� �#DA34AE6?    5f   "   P� 5g   &    �@J�IsMouseOver$
 True��6E   . �5h   *   ��  � �� �#C62DAE6G   5i   '   5k      ��5n      �� 5o      " ��6.   .R�5p   "   �� $��18��6)   $��18��64   $ 9��5q   )   #��z��5r   )   ._�5s   &   �� $��Center=�67   $��Center=�5t   7   5u   #   5v      5x      5y      �� 5{      $��1��5|       �� Orientation$ Vertical=�5}      $��10,27,10,10q�5~      .+�5      �� -   5        $ 	btUserAcc��5      $��0q�5�      $��
My Account��5�      
�������$��10(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��Right=�5�      $��0,0,0,10q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �	#FF2846ED6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �	#FF2846ED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��70��6)   $��18��64   $ 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ listGrid��5�          	RowHeight$ 30Q�5�          ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 5�       $	��285��5�       $	��752��5�       
������    AutoGenerateColumns$
 True��5�          
IsReadOnly$
 True��5�          HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   ColumnHeaderStyle 5�      �� 5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�5�   "   ��  � ��
 ���� 6?   �� 5�   "    � ��$
 Bold"�6?   �� 5�   "    � ��
 �����6?   5�          RowHeaderStyle  5�      �� 5�      :  4System.Windows.Controls.Primitives.DataGridRowHeader"  6$   .�5�   "   ��  � ��
 ���� 6?   �� 5�   "    � ��
 �����6?   5�      5�      5�      5�      5�      5�      5�      