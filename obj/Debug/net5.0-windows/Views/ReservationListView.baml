   M S B A M L   `   `   `  ����F  BReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Reservation.ViewsReservation.Views  5      +    %Reservation.Views.ReservationListView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Reservation.Views     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��.75* �6   �� 5      $
��.25* �6   .+�5   
   �� $��Reservations��6    
  Header#��[  6(   �� 5   
   $��Make a reservation��6   $��1��6.   ��6>   �� *openMakeReservationCommand+�� 5   
   $��1��6   $��0��6    $��2��60   $	��Top=�6D   $��5q�6\   ��6g   �� *Reservation+ �� View 5      �� 5      .P�5      �� $��Rood ID��6%    �� CellTemplate 5       �� 5!      .R�5"   "   �� ��6,   �� *ID+5#      5%      �� 5'      $��	User Name��6%    5(      �� 5)      .R�5*   "   �� ��6,   �� *
Username+5+      5-      �� 5/      $��
Start Date��6%    50      �� 51      .R�52   "   �� ��6,   �� *	StartTime+53      55      �� 57      $��End Date��6%    58      �� 59      .R�5:   "   �� ��6,   �� *	EndTime+5;      5=      5?      5B      5D      5F      