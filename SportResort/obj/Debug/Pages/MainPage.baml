   M S B A M L   `   `   `  ����F  BSportResort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SportResort.PagesSportResort.Pages  5           SportResort.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SportResort.Pages     5        N� Title$6  0Главная страница магазина��5	       N� 
Background �#CCFFEE.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��70* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   $��3��61   ���	#FF45959A���	#263D979D6V   �� 5   
    "  TopInterfaceStackPanelLeftPart#��[  6   .+�5      ��   ButtonInterfaceMain#��[ 6   5      �� 5   
    $  TopInterfaceStackPanelCenterPart#��[ 6   .+�5      ��   ButtonInterfaceOrders#��[ 6   �� 5        ButtonInterfaceShoppingCart#��[ 6   5      �� 5   
    # TopInterfaceStackPanelRightPart#��[ 6   .+�5       ��   ButtonInterfaceProfile#��[ 6   �� 5!         ButtonInterfaceAccountLogout#��[ 6   5"      �� 5$   
   $��1��6   $��0��6$   $��3��64   .��5%      �� -   5         ��Name$ IControlProductsList��5%      $��Center=�69   $��0,30,0,0q�6V   ��5&      �� 5'      .R�5(      �� -   5          ProductCardButtonStyle#��[ 5(   !   5)      5*      ��5,      �� 5-      .R�5.      �  � Orientation$ 
Horizontal=�6$   5/      51      52      �� 53   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6>   $��Bottom=�6K   $
��Left=�6f   $��10,10,10,20q�6�   $��80��6�   .+�54      �� -   5         ��Name$ buttonAddProduct��54       	 MiddleButton#��[	 6P   $
��Left=�6v   $��80��6�   $
��Auto��6�   .��55      �� $!��Добавить товар��6   $��18(�62   $
��Wrap=�6@    �� TextAlignment$ Center=�6T   56      57      �� 58   
   $ 
Horizontal=�6   $��1��6.   $��1��6>   $��Bottom=�6K   $��Right=�6f   $��10,10,20,20q�6�   $��80��6�   .+�59      �� -   5        $ buttonFilterAvailable��59       
 LittleButton#��[
 64   $��Right=�6Z   $��80��6v   $	��150��6�   .��5:      �� $ 
Horizontal=�6   $��Center=�66   $	��130��6Q   .+�5;      �� -   5        	 ��Name$	 checkBoxAvailable��5;      $��Center=�6i   $��5,0,0,0q�6�   
 d� 	IsChecked
 6:   �� *IsAvailableFilterChecked+6�   �� 5<      $:��4Посмотреть только доступные��6    $��18(�6C   $
��Wrap=�6Q   $ Center=�6e   $	��100��6|   $��10,0,0,0q�6�   5=      5>      5?      5E      5F      