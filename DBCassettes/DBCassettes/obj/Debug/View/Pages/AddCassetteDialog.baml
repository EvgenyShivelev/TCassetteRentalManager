   M S B A M L   `   `   `  ����F  BDBCassettes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ENUMENUM  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      .    (DBCassettes.View.Pages.AddCassetteDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "Enmclr-namespace:ENUM     5      9System&clr-namespace:System;assembly=mscorlib     5      $	��350��5   3     � 	Resources  5	         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        S� 5
   
   $ 	GetValues��62   "  5       5      M� 5      $ Enm:Enum+CasseteCondition��6   5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   ]� $��2��6   .+�5      �� $��	10,0,0,58q�6   
���   �$��1q�6<   ��5      �� 5       �� ImageSource 6"   �� *PreviewImage+5!      5"      �� 5#   
   $��1��6   $��2��6%   $��2��69   $��0,0,-0.333,0q�6J   .+�5$      �� -   5         ��Name$ 
Фильм��5$      	 �� Orientation$	 
Horizontal=�6(   $��10q�6A   .+�5%      �� $��
Фильм��6   $��70��6(   65   �� 5&      
 �� DisplayMemberPath$
 FilmName��6a   $	��101��6~   ��6   ��  �� Path$ Films� �� SelectedItem 6>   �� $
 Film�6~   �� 5'      $��0q�6P   
�������$	��5,0q�6w   $��25��6�   ��6   �� $# RefreshFilmsCollectionCommand�.��5(      �� $4��./DBCassettes;component/Assets/view-refresh.png��6   6V   5)      5*      �� 5+      -   5        $ Состояния��5+      $	 
Horizontal=�6,   $��10q�6E   .+�5,      �� $��Состояние��6   $��70��6,   69   �� 5-      $	��130��6�   ��6   ��  �� Source# [   6X   �� $ 	Condition�6�   5.      �� 5/      -   5        $ 
Копия��5/      $	 
Horizontal=�6(   $��10q�6A   .+�50      �� $��
Копий��6   $��70��6(   65   �� 51      $	��130��6   6(   52      �� 53      -   5        $ Цена��53      $	 
Horizontal=�6'   $��10q�6@   .+�54      �� $��Цена��6   $��70��6'   64   �� 55      $	��130��6   6(   56      57      ]� 58   
   $��3��6   $��2��6(   $��	0,0,0.5,0q�65   .+�59      ]� $
��Left=�6   $	��175��6.   .+�5:      �� $	��Top=�6   $��Добавить��6_   
������$	��100��6�   $��30��6�   $��	0,26,0,27q�6�   ��6.   �� *AddCassetteToDataBaseCommand+6�   5;      ]� 5<      $
��Left=�6   $	��175��6.   .+�5=      �� $��Отмена��6L   
���  ��$	��100��6n   $��30��6z   ��6   �� $ CloseDialogWindowCommand�6�   5>      5?      5@      5A      