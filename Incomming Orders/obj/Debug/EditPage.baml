   M S B A M L   `   `   `  ����K  GIncomming Orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Incomming_OrdersIncomming_Orders  5   	   Q-clr-namespace:Incomming_Orders.Business_LayerIncomming_Orders.Business_Layer  5   	       Incomming_Orders.EditPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Incomming_Orders     5   	   HBusiness_Layer-clr-namespace:Incomming_Orders.Business_Layer     5   	     � Title$  EditPage��5	   	   $	��600��6   $	��900��6'    � 	Resources 5
       
  listAG��%Q   &	        �� 5   
   .R�5      �� ��6   �� *	GroupID+63   5      5      .��5      � 
���?���.+�5   
   (� $
��Auto��6   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�66   .+�5      �� $��	Order Id:��6    �� 5      $	��200��6    ��6,   �� *	OrderId+5      �� 5      $ 
Horizontal=�6   $��Stretch=�66   .+�5      �� $��
Assign to:��6    �� 5      -   5         ��Name$ assign��5      $	��200��6.   #��[  6:   5      5      �� 5      $ 
Horizontal=�6   $��Stretch=�66   .+�5      �� $��Priority:  ��6    	� 5       	� 	GroupName$ priority��6"   $��0(Low)��67   	� 5      $ priority��6"   $��	1(Medium)��67   	� 5      $ priority��6"   $��2(High)��67   	� 5       $ priority��6"   $��3(Expedite)��67   5!      �� 5"      $ 
Horizontal=�6   $��Stretch=�66   .+�5#      �� $��	Order Id:��6    �� 5$      ��6    �� *	OrderId+ �� Mode$ TwoWay=�5%      �� 5&      $ 
Horizontal=�6   $��Stretch=�66   .+�5'      �� $��Ordered Date:��6    (  "System.Windows.Controls.DatePicker  5(         Text 6!   �� *	OrderDate+$ TwoWay=�5)      �� 5*      $ 
Horizontal=�6   $��Stretch=�66   .+�5+      �� $��	Order Id:��6    �� 5,      ��6    �� *	OrderId+5-      �� 5.      $ 
Horizontal=�6   $��Stretch=�66   .+�5/      �� $��	Order Id:��6    �� 50      ��6    �� *	OrderId+51      �� 53      $ 
Horizontal=�6   $��Center=�66   .+�54      �� -   5        
���2͚�
�������$��	ExtraBold"�54   I   $��	50 0 50 0q�6`   $
��Save��6t   6�   �� 55      -   5        
���  ��
�������$��	ExtraBold"�55   B   $��	50 0 50 0q�6Y   $��Cancel��6m   6~   56      58      59      5:      5;      