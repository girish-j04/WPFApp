   M S B A M L   `   `   `  ????B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   ?$clr-namespace:WpfApp1.MVVM.ViewModelWpfApp1.MVVM.ViewModel  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   :	viewModel$clr-namespace:WpfApp1.MVVM.ViewModel     5   	     ? WindowStyle$
  None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	   
??????  J? 	AllowDrop .  ? Icon$ Theme/newicon.ico??5   	    ? DataContext 5      *  $WpfApp1.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? ???#272537 ?? CornerRadius$ 40??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5       ? RowDefinitions 5      ?? 5      $??75 ?6    ?? 5      .+?5       ?? $??Weather App??6   $??Center=?5!      $
??Left=?5"      
???????$??22(?5$      $??10,0,0,0q?5%      ?? 5'      $??1??6   .+?5(      	? $
??Home??6   $??50??5)      
???????$??14(?5+         MenuButtonTheme#??[  5,       d? 	IsChecked$
 TrueY?5-      ??5.      ?? *HomeViewCommand+	? 50      $??Featured??6   $??50??51      
???????$??14(?53      #??[  54      ??55      ?? *FeaturedViewCommand+	? 57      $??Forecast??6   $??50??58      
???????$??14(?5:      #??[  5;      ??5<      ?? *WeekViewCommand+5=      ?? 5?      $??1??6   $??1??5@      $??10q?5A      ??5B      ?? *CurrentView+5D      5E      5I      