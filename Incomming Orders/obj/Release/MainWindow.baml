   M S B A M L   `   `   `  ���� K  GIncomming Orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Incomming_OrdersIncomming_Orders  I)clr-namespace:Incomming_Orders.ConvertersIncomming_Orders.Converters  M+clr-namespace:Incomming_Orders.ControlsViewIncomming_Orders.ControlsView  !    Incomming_Orders.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Incomming_Orders     7c)clr-namespace:Incomming_Orders.Converters     Dcontrolsview+clr-namespace:Incomming_Orders.ControlsView     -     �Name$  
mainwindow�� � Title$ Incoming Orders��$
��Auto��$
��Auto�� � 	Resources -   'Incomming_Orders.Converters.SDConverter   sdc3   -Incomming_Orders.Converters.PriorityConverter  pc-  'Incomming_Orders.Converters.DSConverter  dsc-  'Incomming_Orders.Converters.AGConverter  agc8  2Incomming_Orders.Converters.GroupToPersonConverter  gtpc  orderlistcolor �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value �� 
TargetName  	orderview �� Orientation � RowDefinitions � ColumnDefinitions J� OpacityMask �� 	Converter j� Stretch �� ImageSource �� TextAlignment��%.  &	        &	      &	 
     &	      &	      &	      &	 �     7  7  7             �� " ��.���  � �� �� " ��.R��� $��_Border��$ 2q� . ._��� 	 P� 
 �@��
IsSelected . . ��� $ _Border�� � ��
 � �����  � ��
 �  ���� .R��� -   $��Center=�
�������$
��Auto��$��10q�$ 20q�._��� $ 
Horizontal=�.+��  �� $��67 � �� $	��100 ��� $	��200 ��� $	��200 ��� $	��500 �.+�(� $��0��.��A� $	��200��$	��200��$��15�� Z� ���� *
Priority+8   ���� $ Uniform=� �� *DS+8  (� $��1��.���� $ 
Horizontal=�.+��� $ Center=����� *	OrderId+(� $��2��.���� $ Center=����� *	NoOfItems+(� $��3��.���� $ Center=����� *ScheduledDate+8  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFFB0480�� � Offset$ 1Q�� $ 	#FFE6490E��$ 0.406Q�.��� -    �Name$
 grid�� �� $
��0.1* ��� $��* ��� $��0.05* � �� $
��Auto ��� $��* �.+�3   -Incomming_Orders.ControlsView.MainWindowTitle  -     Name$ mainWindowTitle��$��0��$��0��� $��0��$��1�� ��  �� $��* ��� $
��Auto �.+�(� -    (�Name$ viewbox��$��0��$��0��.���� -   $
��time��$
��Auto��$�� ��$ Center=�
�������$
��Wrap=��� -   $	��img��$��0��$��1��$
��Auto��$
��Auto��$ ��Resource/images/logout.png��� $��1��$��0�� �� $��90 ��� $��* � �� $��* �.+��� $��Hidden=�$��0q�$��0��
������ .@��� $��20q����	#FF05D848
�������$��	ExtraBold"�.���  �� $
��Auto � �� $	��110 ��� $	��200 ��� $	��200 ��� $	��500 �.+��� $ Center=�$��0��$��30(�$��Service���� $ 
Horizontal=�$��1��.+��� $ Center=�$��30(�$��	 Order ID���� -   $��deliveredOrdersCheck���� $ Vertical=�.+��� 
��� ���$��Include���� 
��� ���$��	Delivered���� $ Center=�$��2��$��30(�$�� Item Count���� $ Center=�$��3��$��30(�$�� Scheduled Delivery Date���� -	    ��Name$ 
listorders��$��1��#���  $��1q�$��Visible=�
������ #��[ 
�������$y�Visible=�$��	0,10,0,45q�$��Black"�$��2������ �� $
��Auto��$
��Auto��
�������$ 30q�$��10q�$��1��$��1��._�� -
   $��selectedOrder�� �� $	��200 ��� $��35 ��� $��35 ��� $��35 ��� $��35 ��� $	��200 ��� $��35 �.+��� $	��200��$	��200��$��10��
������� Z� ���� $ Uniform=� �� *DS+# [ (� $��1��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$%��Order Id:                      ���� 
�������$��	ExtraBold"����� *	OrderId+(� $��2��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$"��Order Date:                 ���� 
�������$��	ExtraBold"����� *	OrderDate+(� $��3��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$"��Delivery Date:              ���� 
�������$��WrapWithOverflow=�$��	ExtraBold"����� *ScheduledDate+# [  (� $��4��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$��No of Days delayed:    ���� 
�������$��	ExtraBold"����� *DelayedDays+(� $��5��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$!��Assigned to:               ��$��Center=��� $	��100��$	��130������ *AGId+# [ �� .+��� $ 
Horizontal=�.+��� $��Group: ��
��������� $��Center=�
�������$��	ExtraBold"����� *AGId+�� $ 
Horizontal=�.+��� $��Person Id: ��
��������� $��Center=�
�������$��	ExtraBold"����� *AGId+# [  �� ConverterParameter$
 name���� $ 
Horizontal=�.+��� $��Name: ��
��������� $��Center=�
�������$��	ExtraBold"����� *AGId+# [ $ id��(� $��6��$
��Left=�.���� $ 
Horizontal=�.+��� 
�������$��Number of Items:        ���� 
�������$��	ExtraBold"����� *	NoOfItems+� $��3��$��2��
�������