   M S B A M L   `   `   `  ���� F  BAreaSuggest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:AreaSuggest;assembly=AreaSuggestAreaSuggest  F BLifeService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LifeService.ViewLifeService.View _4clr-namespace:LifeService.ViewModel.WeatherViewModel&LifeService.ViewModel.WeatherViewModel .   (LifeService.View.WeatherView.WeatherView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     FareaSuggest.clr-namespace:AreaSuggest;assembly=AreaSuggest     /viewclr-namespace:LifeService.View     Flocal4clr-namespace:LifeService.ViewModel.WeatherViewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  .  (System.Windows.Interactivity.Interaction    Triggers  /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *LoadDataCommand+   CommandParameter ��  �� ElementName$ 	main_grid�� � 	Resources B <LifeService.ViewModel.WeatherViewModel.DegreeFormatConverter   DegreeFormatConverter��%   &	          .��(� .��� -   $��	main_grid��$	��200��$	��300�� � ColumnDefinitions �� $��* ��� $��2* �.+�� $��0��! LifeService.View.GridHelper   
ShowBorder . $��0,5,0,5q�.+��� -   	 ��Name$	 image��$
��Left=�$��87��$	��Top=�$��87��$��UniformToFill=�$��3,3,0,0q����� 
 �� Path$
 WeatherIcon� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -    ��Name$ label2��$
��Left=�$��	31,98,0,0q�$	��Top=����� *
ResultCity+$ PropertyChanged=��� -   $ label3��$
��Left=�$��
31,123,0,0q�$	��Top=����� *ResultWeather+$ PropertyChanged=��� -   $ label4��$
��Left=�$��
31,148,0,0q�$	��Top=����� *ResultDegree+$ PropertyChanged=�� $��1��$��0,5,0,5q�.+�	�  	� 	GroupName$ WeatherFormat��$	��°F��$
��Left=�$��
147,94,0,0q�$	��Top=� d� 	IsChecked �� *DegreeFormat+ �� 	Converter# [   �� ConverterParameter$ 1��	� $ WeatherFormat��$	��°C��$
��Left=�$��
104,94,0,0q�$	��Top=� �� *DegreeFormat+# [  $ 0���� -   $ label��$��设置城市：��$
��Left=�$��	10,46,0,0q�$	��Top=�   AreaSuggest.SuggestCTR  -     Name$ 
suggestCTR�� K� ZIndex$
 1000��$��	78,48,0,0q�$
��Left=�$	��112��$	��Top=�    $ 	LostFocus��.    �� *LostFocusCommand+ �� $ 
suggestCTR���� -   $ label1��$��设置温度格式：��$
��Left=�$��	10,88,0,0q�$	��Top=��� -	    ��Name$ button��$��更改��$
��Left=�$��115,165,0,0q�$	��Top=�$��75��$��25������ *SaveButtonCommand+���� $ 	main_grid���� -
   $ label5��
���  ��$6��0输入有误!(应输入城市，如：北京市)��$
��Left=�$��	73,68,0,0q�$	��Top=�$��20��$	��127��$��7(�y��� *IsVisibility+$ PropertyChanged=�