   M S B A M L   `   `   `  ����U  QManagementPanelProject.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ManagementPanelProject.WPF.ViewManagementPanelProject.WPF.View  5   	   /    )ManagementPanelProject.WPF.View.AdminView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ManagementPanelProject.WPF.View     5   	   -   5          � Title$  Admin Panel��5   	   $	��450��6   $	��800��6*    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 	#FFA28C24��6#   
 � Offset$
 0Q�65   � 5      $	 	#FFD87FC1��6#   $

 0.75Q�65   � 5      $	 	#FF384884��6#   $
 1Q�65   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5       � $	 	#FF54536F��6#   $
 0Q�65   � 5!      $	 	#FF5B1F1F��6#   $
 1Q�65   5"      ._�5$      �  � RowDefinitions 5%      �� 5&      $��30 �6$   �� 5'      .+�5)      � $��0��6    � ColumnDefinitions 5+      �� 5,      �� 5-      $��25 �6+   �� 5.      $��25 �6+   �� 5/      $��5 �6+   .+�52      �� -   5         ��Name$ txtAdm��52       $��ADMIN PANEL��60   
�������$��10(�54       $��
Montserrat)�55       $��0��56       $��Center=�57       $��10,0,0,0q�58       �� 59      -   5         ��Name$ btnMinimize��59      $��0q�5:      $��-��5;      
�������$��16(�5=      $��
Montserrat)�5>       � Cursor$
 Hand��5?      $��1��5@      ��5C      �� 5D       �� 
TargetType" ��6$   .�5E   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5F   "   P� 5G   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5H   *   ��  � �� �#278BEF6G   5I   '   5K      ��5N      �� 5O       �� 
TargetType" ��6.   .R�5P   "   �� $��18��6)   $��18��64   $ 9��5Q   )   #��z��5R   )   ._�5S   &   �� $��Center=�67   $��Center=�5T   7   5U   #   5V      5Y      �� 5[      -   5        $ btnClose��5[      $��0q�5\      $��X��5]      
�������$��12(�5_      $��
Montserrat)�5`      $
 Hand��5a      $��2��5b      ��5e      �� 5f      " ��6$   .�5g   "   ��  � �� �#DA34AE6?    5h   "   P� 5i   &    �@J�IsMouseOver$
 True��6E   . �5j   *   ��  � �� �#C62DAE6G   5k   '   5m      ��5p      �� 5q      " ��6.   .R�5r   "   �� $��18��6)   $��18��64   $ 9��5s   )   #��z��5t   )   ._�5u   &   �� $��Center=�67   $��Center=�5v   7   5w   #   5x      5z      5{      �� 5}      $��1��5~       �� Orientation$ Vertical=�5      $��
10,0,10,10q�5�      .+�5�      �� -   5        $ btNewAcc��5�      $��0q�5�      $��New Account��5�      
�������$��10(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��Right=�5�      $��0,0,0,10q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �	#FF2846ED6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �	#FF2846ED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��70��6)   $��18��64   $ 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��listGrid��5�       $
��Left=�5�       $��	12,21,0,0q�5�          	RowHeight$ 30Q�5�          ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 5�       $	��258��5�       $	��753��5�       
������    AutoGenerateColumns$
 True��5�          
IsReadOnly$
 True��5�          RowBackground
 ���� 
�������   HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   ColumnHeaderStyle 5�      �� 5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�5�   "   ��  � ��
 ���� 6?   �� 5�   "    � ��$
 Bold"�6?   �� 5�   "    � ��
 �����6?   5�          RowHeaderStyle  5�      �� 5�      :  4System.Windows.Controls.Primitives.DataGridRowHeader"  6$   .�5�   "   ��  � ��
 ���� 6?   �� 5�   "    � ��
 �����6?   5�      ! � ContextMenu! 5�      �� 5�      .@�5�   "   m� -   5        " m�Name$" addClick��5�   +   $	��Add��6=   6L   m� 5�   "   -   5        $" modifyClick��5�   +   $��Modify��6@   6R   m� 5�   "   -	   5        $" deleteClick��5�   +   $��Delete��6@   6R   m� 5�   "   -
   5        $" refreshClick��5�   +   $��Refresh Grid��6A   6Y   5�      5�      5�      5�      5�      5�      5�      