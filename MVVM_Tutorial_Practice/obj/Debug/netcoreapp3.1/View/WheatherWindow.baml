   M S B A M L   `   `   `  ����Q  MMVVM_Tutorial_Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MVVM_Tutorial_Practice.ViewMVVM_Tutorial_Practice.View  5   	   S.clr-namespace:MVVM_Tutorial_Practice.ViewModel MVVM_Tutorial_Practice.ViewModel  5   	   i9clr-namespace:MVVM_Tutorial_Practice.ViewModel.Converters+MVVM_Tutorial_Practice.ViewModel.Converters  5   	   0    *MVVM_Tutorial_Practice.View.WheatherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:MVVM_Tutorial_Practice.View     5   	   =vm.clr-namespace:MVVM_Tutorial_Practice.ViewModel     5   	   Jconv9clr-namespace:MVVM_Tutorial_Practice.ViewModel.Converters     5   	     � Title$  WheatherWindow��5
   	   $	��550��6    $	��430��6-    � 	Resources 5      8   2MVVM_Tutorial_Practice.ViewModel.WheatherViewModel   vmB   <MVVM_Tutorial_Practice.ViewModel.Converters.RainingConverter  raining��%:   &	        &	        5   
   6     5   
   6    5      .��5      �  � DataContext# [  6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF7789FF��6   � 5      $ 	#FFA2CCFF��6    � Offset$ 1Q�61   � 5      $ 	#FF849EFF��6   $ 0.233Q�61   5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��20q�6   .+�5      �� $��Search City:��6   $��5q�6,   �� 5      $��8q�6   $��2q�5      
���������5!      �� *Query+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5"      $��Search��6   $��15q�5#      ��5$      �� *searchCommand+��5%      �� *Query+�� 5&      ��6   �� *cities+
 �� SelectedValue
 66   �� *SelectedCity+��5'      �� 5(      .R�5)      � .+�5*      �� ��6(   �� *LocalizedName+5+      5,      5.      5/      � 50   
   $��1��6    51      �� *
wheather+ J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         Color$ 	#FF8DEEEE��6#      	Direction$	 443Q�54   #      Opacity$
 0.79Q�55   #      ShadowDepth$ 6Q�56   #      
BlurRadius$
 49.7Q�57   #   ��59      �� 5:      $ 0.5,1&�6&   $ 0.5,0&�5;   &   .��5<      � $ 	#FF2063D8��6#   � 5=      $ 	#FF10A8D4��6#   $ 1Q�5>   #   5?       � ColumnDefinitions 5A      �� 5B      $��* �6#   �� 5C      $
��Auto �6#   .+�5E      �� $
��0 10q�6   .+�5F      �� # [  6   ���#f4f4f8$��21(�5H      $
��20 0q�5I      ��5F   >   �� *SelectedCity.LocalizedName+5I      �� 5J      ���#f4f4f8$��17(�5L      $
��20 0q�5M      ��5J      �� *WeatherText+5M      �� 5N      ���#f4f4f8$��17(�5P      $
��20 0q�5Q      ��5N      �� *HasPrecipitation+ �� 	Converter# [ 5Q      5R      �� 5S      $��1��6   $��Center=�5T      ���#f4f4f8$��28(�5W      $
��20 0q�5X      ��5V      �� *Temperature.Metric.Value+ �� StringFormat$ {0}°C��5X      5Y      5Z      5[      