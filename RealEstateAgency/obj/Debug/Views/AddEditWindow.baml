   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   K GRealEstateAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RealEstateAgency.ModelRealEstateAgency.Model 5   	   ?$clr-namespace:RealEstateAgency.ViewsRealEstateAgency.Views 5   	   G(clr-namespace:RealEstateAgency.BehaviorsRealEstateAgency.Behaviors 5
   	   *   $RealEstateAgency.Views.AddEditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   6model$clr-namespace:RealEstateAgency.Model     5   	   6local$clr-namespace:RealEstateAgency.Views     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   8	behaviors(clr-namespace:RealEstateAgency.Behaviors  5
   	   -   5          �Name$  AddEditWindowName��5   	    � Title$ AddEditWindow��5   	   $	��500��5   	   $	��500��5   	    � 	Resources 5         estateTypesList S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName��%�   &	        S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ model:Estate+Type��6   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5    
   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   .+�54   
   �� $��0��6   $��0��6$   $
��Type��61   $��Center=�6=   $��Center=�6Z   �� 55   
   $��0��6�   $��1��6�   $	��5,0q�6�   $��Center=�6�   $��Center=�6�   ��6   �� 	 �� Source#	 [    EnumValuesToLabelConverter
 �� 	Converter#
 [  �� SelectedItem 56      `� 57       " EnumValueToLabelMultiConverter `� 	Converter# [ 6    `� Mode$ TwoWay=�6[   .1�58      ��  �� Path$ EstateProperty.EstateType�6    �� Mode$ TwoWay=�6?   �� 59      $ OneWay=�6E    �� RelativeSource 6   �� *Self+6E   5:      5<      �� 5=   
   $��0��6   $��1��6$   $��Surface��61   $	��5,0q�6@   $��Center=�6M   $��Center=�6j   �� 5>   
   $��1��6:   $��1��6J   $	��5,0q�6W   $��Center=�6e   $��Center=�6�   ��6   �� *EstateProperty.Surface+.��6�   .  (System.Windows.Interactivity.Interaction   	Behaviors 5?      7  1RealEstateAgency.Behaviors.NumericTextBoxBehavior  5@         AllowDecimal .  63   .��5A   '   5B      �� 5C   
   $��0��6   $��2��6$   $��Surface Carrez��61   $	��5,0q�6G   $��Center=�6T   $��Center=�6q   �� 5D   
   $��1��6@   $��2��6P   $	��5,0q�6]   $��Center=�6k   $��Center=�6�   ��6   �� *EstateProperty.SurfaceCarrez+.��6�    5E        5F       .  63   .��5G   '   5H      �� 5I   
   $��0��6   $��3��6$   $��Nombre de pièces��61   $	��5,0q�6I   $��Center=�6V   $��Center=�6s   �� 5J   
   $��1��6=   $��3��6M   $	��5,0q�6Z   $��Center=�6h   $��Center=�6�   ��6   �� *EstateProperty.RoomsCount+.��6�    5K        5L       .  63   .��5M   '   5N      �� 5O   
   $��0��6   $��4��6$   $��Adresse��61   $	��5,0q�6@   $��Center=�6M   $��Center=�6j   �� 5P   
   $��1��6:   $��4��6J   $	��5,0q�6W   $��Center=�6e   $��Center=�6�   ��6   �� *EstateProperty.Address+6�   �� 5Q   
   $��0��6   $��5��6$   $��Code postal��61   $	��5,0q�6D   $��Center=�6Q   $��Center=�6n   �� 5R   
   $��1��66   $��5��6F   $	��5,0q�6S   $��Center=�6a   $��Center=�6�   ��6   �� *EstateProperty.Zip+.��6�    5S        5T       .  63   .��5U   '   5V      �� 5W   
   $��0��6   $��6��6$   $��Ville��61   $	��5,0q�6>   $��Center=�6K   $��Center=�6h   �� 5X   
   $��1��67   $��6��6G   $	��5,0q�6T   $��Center=�6b   $��Center=�6�   ��6   �� *EstateProperty.City+6�   �� 5Y   
   $��0��6   $��7��6$   $��Prix estimé��61   $	��5,0q�6D   $��Center=�6Q   $��Center=�6n   �� 5Z   
   $��1��6A   $��7��6Q   $	��5,0q�6^   $��Center=�6l   $��Center=�6�   ��6   �� *EstateProperty.EstimatedPrice+.��6�    5[        5\       . 63   .��5]   '   5^      �� 5_   
   $��0��6   $��8��6$   $��Charges annuelles��61   $	��5,0q�6J   $��Center=�6W   $��Center=�6t   �� 5`   
   $��1��6@   $��8��6P   $	��5,0q�6]   $��Center=�6k   $��Center=�6�   ��6   �� *EstateProperty.AnnualCharges+.��6�    5a        5b       . 63   .��5c   '   5d      �� 5e   
   $��0��6   $��9��6$   $��Taxe de propriété��61   $	��5,0q�6J   $��Center=�6W   $��Center=�6t   �� 5f   
   $��1��6@   $��9��6P   $	��5,0q�6]   $��Center=�6k   $��Center=�6�   ��6   �� *EstateProperty.PropertyTaxes+.��6�    5g        5h       . 63   .��5i   '   5j      �� 5k   
   $��0��6   $��10��6$   $��Numéro d'étage��62   $	��5,0q�6H   $��Center=�6U   $��Center=�6r   �� 5l   
   $��1��6>   $��10��6N   $	��5,0q�6\   $��Center=�6j   $��Center=�6�   ��6   �� *EstateProperty.FloorNumber+.��6�    5m        5n       .  63   .��5o   '   5p      �� 5q   
   $��0��6   $��11��6$   $��Nombre d'étages total��62   $	��5,0q�6O   $��Center=�6\   $��Center=�6y   �� 5r   
   $��1��6=   $��11��6M   $	��5,0q�6[   $��Center=�6i   $��Center=�6�   ��6   �� *EstateProperty.FloorCount+.��6�    5s        5t       .  63   .��5u   '   5v      �� 5w   
   $��0��6   $��12��6$   $��	Ascenseur��62   $	��5,0q�6C   $��Center=�6P   $��Center=�6m   �� 5x   
   $��1��6;   $��12��6K   $	��5,0q�6Y   $��Center=�6g   $��Center=�6�   ��6   �� *EstateProperty.Elevator+6�   �� 5y   
   $��0��6   $��13��6$   $��Photo��62   $	��5,0q�6?   $��Center=�6L   $��Center=�6i   � 5z   
   $��1��6   $��13��6    5{      �� 5|      $��2* �6#   �� 5}      $��1* �6#   .+�5      �� $��0��6V   $	��5,0q�6f   $��Center=�6s   $��Center=�6�    �� 
IsReadOnly . ��6   �� *	ImagePath+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5�      $��	Parcourir��6   $��1��6)   $	��5,0q�69   ��6F   �� *ChooseImage+5�      �� 5�   
   $��0��6   $��14��6$   $��
Commercial��62   $	��5,0q�6D   $��Center=�6Q   $��Center=�6n   �� 5�   
   $��1��6?   $��14��6O   $	��5,0q�6]   $��Center=�6k   $��Center=�6�   ��6   �� *EstateProperty.CommercialId+.��6�    5�        5�       .  63   .��5�   '   5�      �� 5�   
   $��Annuler��6   $��15��6#   $��0��61   $	��5,0q�6A   ��6N   �� *Cancel+��6i   ��  �� ElementName$ AddEditWindowName���� 5�   
   $��Valider��6   $��15��6#   $��1��61   $	��5,0q�6A   ��6N   �� *Valid+��6h   �� $ AddEditWindowName��5�      5�      