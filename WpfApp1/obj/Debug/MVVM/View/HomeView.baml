   M S B A M L   `   `   `  ????B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.MVVM.ViewWpfApp1.MVVM.View  5           WpfApp1.MVVM.View.HomeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WpfApp1.MVVM.View     5      .??5
      ?? .+?5   
   ??   ?? Orientation$  
Horizontal=?6   $??Center=?6.   .+?5      ?? $??Today's Forecast??6   
???????$??28(?5      $
??Left=?5      $??	5,10,0,20q?5      ?? 5      -   5        $??
searchCity??5      $	??250??5      $??40??5      $??Center=?5      $
??Left=?5      $??10q?5      $??1??5      5      5      ?? 5   
   $  
Horizontal=?6   $??0,0,0,10q?5       .+?5"      ?? $	??400??6   $	??200??5#      ??5%      ?? 5&       ?? 
StartPoint$	 0,0&?6*    ?? EndPoint$	 1,2&?6;   .??5'      ?  ? Color$ #5bc3ff??6'    ? Offset$	 0.0Q?67   ? 5(      $ #3aa0ff??6'   $	 1.0Q?67   5)       J? Clip 5,      ?? 5-       ?? RadiusX$ 10Q?6(    ?? RadiusY$ 10Q?5.   (    ?? Rect$ 0,0,400,200?5/   (   ._?52      ? .+?54      ?? .+?55      ?? -   5        $??Temperature??55   $   $??Expected
 28º C ??56       
???????$??28(?58       $??
20,10,10,0q?59       ?? 5;      $??View detailed info??6$   
???????$??18(?5=       $??
20,10,10,0q?5>       5?      ?? 5A      $	??134??6   $??84??5B      $??/Images/weather-icon.png??5C      $	??Top=?5D      $
??Left=?5E      $??242,100,0,0q?63   	 J? RenderTransformOrigin$	 0.535,0.898&?6H   6n   5F      5G      ?? 5I      $	??200??6   $	??200??5J      
 ?? CornerRadius$
 10??5K      $??45,0,0,0q?5L      ??5N      ?? 5O      $	 0,0&?6*   $	 1,2&?6;   .??5P      ? $ #ffc554??6'   $	 0.0Q?67   ? 5Q      $ #ffb73a??6'   $	 1.0Q?67   5R      5U      5V      ?? 5X   
    ? 	Resources 5Z       ?? 
TargetType ?? Property ?? Value??%X   '??       ?? 5[      " ??6   .?5\      ??  ? ??$ 15,0,0,0q?6/   5]      5^      .+?5`      ?? $??Select City??6   
???????$??20(?5b      $
??Left=?5c      $??0,0,0,10q?5d      ?? 5f      $  
Horizontal=?6   .+?5h      ?? -   5        $??	Hyderabad??5h      $	??150??5i      $	??150??5j      ???#8443ff$
 10??5l      $??0q?5m         HighlightOnHover#??[  5o      ._?5r      ?? $??	Hyderabad??6    
???????$??28(?5t       $??Center=?5u       $??Center=?5v       5w      ?? 5y      -   5        $??	Bangaluru??5y      $	??150??5z      $	??150??5{      ???#4e99ff$
 10??5}      #??[  5      ._?5?      ?? $??	Bangaluru??6    
???????$??28(?5?       $??Center=?5?       $??Center=?5?       5?      ?? 5?      -   5        $??Manila??5?      $	??150??5?      $	??150??5?      ???#4eff91$
 10??5?      #??[  5?      ._?5?      ?? $??Manila??6    
???????$??28(?5?       $??Center=?5?       $??Center=?5?       5?      ?? 5?      -   5        $??Chennai??5?      $	??150??5?      $	??150??5?      ???#ecff4e$
 10??5?      #??[  5?      ._?5?      ?? $??Chennai??6    
???????$??28(?5?       $??Center=?5?       $??Center=?5?       5?      5?      5?      5?      5?      