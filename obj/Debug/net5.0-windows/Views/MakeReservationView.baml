   M S B A M L   `   `   `  ����F  BReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Reservation.ViewsReservation.Views  5      +    %Reservation.Views.MakeReservationView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Reservation.Views     5      .��5	      �   � 	Resources  5
   
    �� 
TargetType �� Property �� Value��%T   '��       �� 5      " ��6   .�5      ��  � ��$
 Auto �6+   5      5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Make a Reservation��6   $��Center=�6.    
  Header#��[  6K   � 5   
   $��1��6   $��10q�6    5      �� 5      �� 5      .+�5"      �� $��0��6   $
��Name��6%   �� 5$      $��1��6   ��6#   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5&      � 5(   
   $��2��6   $��10q�6    5*      �� 5+      �� 5,       � ColumnDefinitions 5/      �� 50      �� 51      .+�54      �� $��0��6   $��0��6%   $��Floor Number��65   �� 56      $��1��6   $��0��6#   ��63   �� *FloorNumber+$ PropertyChanged=��� 58      $��0��6   $��1��6%   $��Room Number��66   �� 5:      $��1��6   $��1��6#   ��63   �� *
RoomNumber+$ PropertyChanged=�5<      � 5>   
   $��3��6   $��10q�6    5@      �� 5A      �� 5B       5E      �� 5F      �� 5G      .+�5J      �� $��0��6   $��0��6%   $��
Start Date��65   (  "System.Windows.Controls.DatePicker  5L      $��1��6   $��0��6&      SelectedDate 66   �� *	Starttime+�� 5N      $��0��6   $��1��6%   $��End Date��66     5P      $��1��6   $��1��6&    66   �� *	Endtime+5R      �� 5T   
   $��4��6   $��10q�6"    �� Orientation$ 
Horizontal=�6.   .+�5U      �� $��Submit��6   ��6&   �� *SubmitCommand+�� 5V      $��Cancel��6   ��6&   �� *CancelCommand+5W      5Y      5Z      