   M S B A M L   `   `   `  ????C  ?Lopushok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LopushokLopushok  5          Lopushok.MasterEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Lopushok     5        N? Title$  MasterEditPage??5	      .??5      ? ???#CEFFF9 ? ColumnDefinitions 5   
   ?? 5      $
??119* ?6   ?? 5      $
??281* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Right=?6   $
??Wrap=?60   $(??"Время начала смены??6D   $??Center=?6^   $??35(?6y   ?? 5   
   $??Right=?6   $??1??60   $
??Wrap=?6=   $&?? Время конца смены??6Q   $??Center=?6j   $??35(?6?   ?? 5   
   $??Right=?6   $??2??60   $
??Wrap=?6=   $??Мастер??6Q   $??Center=?6_   $??35(?6z   $??5q?6?   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DataPickerNach??5      $??1??6Z   $??Stretch=?6j   $??Center=?6?   $??Gabriola)?6?   $??18(?6?   $??46??6?      SelectedDateFormat$
 Long=?6?      SelectedDate 6-   ?? *$"Время_начала_смены+6?     5   
   -   5        $??DataPickerKon??5      $??1??6U   $??Stretch=?6e   $??Center=?6?   $??1??6?   $??Gabriola)?6?   $??18(?6?   $??46??6?   $
 Long=?6?    6*   ?? *" Время_конца_смены+6?   ?? 5   
   -   5         ??Name$ ComboMaster??5      $
??Left=?6(   $??20(?6C   $??10q?6Q   $??30??6]   $	??490??6i    ?? DisplayMemberPath$ Фамилия??6?   $??1??6?   $??2??6?    ?? SelectedItem 6u   ?? *Мастер_смены+6?   ?? 5   
   -   5        	 ??Name$	 
ButtonSave??5      $??Сохранить??6%   $??Center=?69   $??5??6V   $??Center=?6c   $??2??6?   5       5!      