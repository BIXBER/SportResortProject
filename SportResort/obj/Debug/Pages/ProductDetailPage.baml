   M S B A M L   `   `   `  ����F  BSportResort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SportResort.PagesSportResort.Pages  5      )    #SportResort.Pages.ProductDetailPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SportResort.Pages     5        N� Title$4  .Детальна страница товара��5	       N� 
Background �#CCFFEE.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��70* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   $��3��61   ���	#FF45959A���	#263D979D6V   �� 5   
    "  TopInterfaceStackPanelLeftPart#��[  6   .+�5      ��   ButtonInterfaceMain#��[ 6   5      �� 5   
    $  TopInterfaceStackPanelCenterPart#��[ 6   .+�5      ��   ButtonInterfaceOrders#��[ 6   �� 5        ButtonInterfaceShoppingCart#��[ 6   5      �� 5!   
    # TopInterfaceStackPanelRightPart#��[ 6   .+�5"      ��   ButtonInterfaceProfile#��[ 6   �� 5#         ButtonInterfaceAccountLogout#��[ 6   5$      �� 5%   
   $��1��6   $��0��6$   $��3��64   $��10q�6H   $��Stretch=�6U   .��5&      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   ���	#FF34866A.+�5'      �� ���	#E5005236���#6bc4a6$��2q�6F    �� Padding$ 5q�6Z   ._�5(      �� $ Vertical=�6!   $	��200��68   .+�5)      �� ��6    �� *SelectedProduct.image+ # ByteArrayToBitmapImageConverter �� 	Converter# [  �� ConverterParameter$ Source���� 5*      $ 
Horizontal=�6%   .+�5+      �� $��NoWrap=�6(   $��Наличие:��6>   $��18(�6N   $��Bahnschrift SemiBold)�6\   $��Center=�6~   $��	0,10,10,0q�6�   $��Center=�6�   �� 5,      $��16(�6(   $��Bottom=�6�   $��Bahnschrift SemiLight)�6�   ��66   �� *SelectedProduct.is_available+ 	 IsAvailableTextConverter# [	 $ 
Foreground����5-   "   �� 5.   &    �� Path$" SelectedProduct.is_available�6.   # [	 6R   50      51      52      53      �� 55      $	��370��6   $ Vertical=�6)   ���#6bc4a6.+�56      �� $
��Wrap=�6    $��26(�6[   $��Bahnschrift Light)�6i   $��0,5,0,30q�6�   	 �� Padding$	 5,0,5,0q�6�   ��64   �� *SelectedProduct.title+6�   �� 57      $$��Описание товара:��6   $��24(�67   $��Bahnschrift SemiBold)�6E   $��5,0,5,0q�6g   �� 58      $
��Wrap=�6    $��16(�6a   $��Bahnschrift Light)�6o   $��0,5,0,30q�6�   $	 5,0,5,0q�6�   ��64   �� *SelectedProduct.description+6�   �� 59      $��	Цена:��6   $��24(�6,   $��Bahnschrift SemiBold)�6:   $��5,0,5,0q�6\   �� 5:      $
��Wrap=�6    $��Bahnschrift SemiBold)�6Z   $��20(�6|   $	 5,0,5,0q�6�   $��0,5,0,0q�6�   ��64   �� *SelectedProduct.cost+6�   5;      �� 5=      $��10,10,10,10q�6   $ Vertical=�62   $��1��6I   $��1��6Y   $��Center=�6f   .+�5>      �� -   5        
 ��Name$
 editProductStackPanel��5>   !   $ Vertical=�6@   .+�5?      �� -   5         ��Name$ buttonEditProduct��5?   !   $��1��6<    
 MiddleButton#��[
 6I   $	��130��6o   $
��Auto��6{   $��0,0,0,10q�6�   .��5@      �� $!��Изменить товар��6(   $��16(�6>   $
��Wrap=�6L    �� TextAlignment$ Center=�6`   5A      �� 5B      -   5        $��1��5B   !   #��[
 6.   $	��130��6T   $
��Auto��6`   ���	#FFFF4C4C���	#FFBC0707���	#FFA40000.��5C      �� -   5         ��Name$ buttonDeleteProduct��5C   (   $��Удалить товар��6E   $��16(�6Z   $
��Wrap=�6h   $ Center=�6|   5D      5E      �� 5F      $ Vertical=�6!   $��Bottom=�68   $��	0,230,0,0q�6S   .+�5G      �� -   5        $��1��5G   !     LittleButton#��[ 6.   $	��130��6T   $��0,0,0,15q�6`   .��5H      �� $(��"Добавить в корзину��6(   $��16(�6B   $
��Wrap=�6P   $ Center=�6d   5I      5J      5K      5L      5M      5N      5O      