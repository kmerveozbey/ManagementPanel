   M S B A M L   `   `   `  ����U  QManagementPanelProject.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ManagementPanelProject.WPF.ViewManagementPanelProject.WPF.View  5   	   /    )ManagementPanelProject.WPF.View.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ManagementPanelProject.WPF.View     5   	   -   5          � Title$  Login��5   	   $	��453��6   $	��346��6$    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8A16C1��6#   $ 1Q�63   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $ #060531��6#   $ 0Q�63   � 5      $ #1B1448��6#   $ 1Q�63   5      ._�5       � 	 � RowDefinitions	 5!      �� 5"      $��30 �6$   �� 5#      .+�5%      � $��0��6   
 � ColumnDefinitions
 5&      �� 5'      �� 5(      $��25 �6+   �� 5)      $��25 �6+   �� 5*      $��5 �6+   .+�5-      �� -   5         ��Name$ Login��5-       $��LOG IN��6/   
�������$��10(�5/       $��
Montserrat)�50       $��0��51       $��Center=�52       $��10,0,0,0q�53       �� 55      -   5         ��Name$ btnMinimize��55      $��0q�56      $��-��57      
�������$��16(�59      $��
Montserrat)�5:       � Cursor$
 Hand��5;      $��1��5<      ��5?      �� 5@       �� 
TargetType" ��6$   .�5A   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5B   "   P� 5C   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5D   *   ��  � �� �#278BEF6G   5E   '   5G      ��5J      �� 5K       �� 
TargetType" ��6.   .R�5L   "   �� $��18��6)   $��18��64   $ 9��5M   )   #��z��5N   )   ._�5O   &   �� $��Center=�67   $��Center=�5P   7   5Q   #   5R      5U      �� 5W      -   5        $ btnClose��5W      $��0q�5X      $��X��5Y      
�������$��12(�5[      $��
Montserrat)�5\      $
 Hand��5]      $��2��5^      ��5a      �� 5b      " ��6$   .�5c   "   ��  � �� �#DA34AE6?    5d   "   P� 5e   &    �@J�IsMouseOver$
 True��6E   . �5f   *   ��  � �� �#C62DAE6G   5g   '   5i      ��5l      �� 5m      " ��6.   .R�5n   "   �� $��18��6)   $��18��64   $ 9��5o   )   #��z��5p   )   ._�5q   &   �� $��Center=�67   $��Center=�5r   7   5s   #   5t      5v      5w      �� 5x      $	��220��6   $��1��5y       �� Orientation$ Vertical=�5z      $��0,35,0,0q�5{      .+�5~      �� -   5        $ ManagementPanel��5~       $��MANAGEMENT PANEL��69   
�������$��20(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      -   5        $ lblUsername��5�       
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      
������ $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      �� 5�      -   5        $ lblPassword��5�       
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       G� 5�      -	   5         G�Name$ txtPass��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������ 
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      �� 5�      -
   5        $ btnLogin��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462AD86?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      5�      5�      5�      5�      