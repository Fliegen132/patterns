   M S B A M L   `   `   `  ����F  BCounterMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CounterMVVMCounterMVVM  5   	       CounterMVVM.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:CounterMVVM     5   	   -   5          � Title$  Counter MVVM��5   	   $	��200��6   $	��300��6+    � DataContext 5      "   CounterMVVM.CounterViewModel  5	   
   .��5      � $��0,0,0,-6q�6    � ColumnDefinitions 5   
   �� 5      $
��254* �6   �� 5      $	��41* �6   �� 5      $��5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��+��6   $��
10,10,5,10q�6   $��2��6V   ��61   �� *IncrementCommand+6V   �� 5   
   $��-��6   $��	10,5,5,15q�6   $��1��6U   $��2��6b   ��60   �� *DecrementCommand+6b   �� 5   
   $��2��6   $��30(�6?   $
��Left=�6M   $��142,10,0,14q�6h   ��6!   �� *CounterValue+6h   �� 5   
   -   5         ��Name$ ww��5   !   $��2��6   $��30(�6-   $
��Left=�6;   $��172,10,0,14q�6V   5      5      