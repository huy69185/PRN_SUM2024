   M S B A M L   `   `   `  ����X  TBookManagement_HoangNgocTrinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BookManagement_HoangNgocTrinhBookManagement_HoangNgocTrinh  5   	   .    (BookManagement_HoangNgocTrinh.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BookManagement_HoangNgocTrinh     5   	   -   5          �Name$  BookMainWindow��5   	    � Title$ Book Manager - ver.24-SU��5   	   $	��685��6*   $
��1220��67   ���#ff2800 � WindowStartupLocation$ CenterScreen=�6Y    � 
ResizeMode$ NoResize=�6~   .��5	      � .+�5
   
   �� $��Book Manager��6   $
��Left=�6'   $��80��6B   $��	31,20,0,0q�6N   $	��Top=�6a   $	��520��6y   $��Heavy"�6�   $��50(�6�   �� 5   
   $��
ver. 24-SU��6   $
��Left=�6%   $��50��6@   $��
432,40,0,0q�6L   $	��Top=�6`   $	��275��6x   $��30(�6�   �� 5   
   $��	Book List��6   $
��Left=�6$   $��55��6?   $��
35,274,0,0q�6K   $	��Top=�6_   $	��165��6w   �� 5   
   $
��Left=�6   $��95��6/   $��
39,144,0,0q�6;   
���   �$	��Top=�6^   $
��1145��6v   ���#ffff006�   �� 5   
   $��	Book Name��6   $
��Left=�6$   $��45��6?   $��
73,174,0,0q�6K   $	��Top=�6_   $	��107��6w   ���#ff45006�   �� 5   
   -   5         ��Name$ BookNameTextBox��5      $
��Left=�6+   $��45��6F   $��193,170,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��275��6�   $��0��6�   �� 5   
   $��	Book Desc��6   $
��Left=�6$   $��45��6?   $��514,174,0,0q�6K   $	��Top=�6`   $	��107��6x   ���#ff45006�   �� 5   
   -   5        $ DescriptionTextBox��5      $
��Left=�6.   $��45��6I   $��628,170,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��275��6�   $��1��6�   �� 5   
   -   5         ��Name$ SearchButton��5      $��Search��6'   $
��Left=�68   $��50��6S   $��989,166,0,0q�6_   $	��Top=�6t   $	��165��6�   $��2��6�   6�   �� 5   
   -   5        $��Create Book��5      $
��Left=�6'   $��50��6B   $��1019,319,0,0q�6N   $	��Top=�6d   $	��165��6|   $��4��6�      ButtonYellow#��[  6�   6�   �� 5   
   -   5        $ UpdateButton��5      $��Update Book��6'   $
��Left=�6=   $��50��6X   $��1019,389,0,0q�6d   $	��Top=�6z   $	��165��6�   $��5��6�   #��[  6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��Delete Book��6'   $
��Left=�6=   $��50��6X   $��1019,461,0,0q�6d   $	��Top=�6z   $	��165��6�   $��6��6�   #��[  6�   6�   �� 5   
   -   5        $ 
QuitButton��5      $
��Quit��6%   $
��Left=�64   $��50��6O   $��1019,559,0,0q�6[   $	��Top=�6q   $	��165��6�   $��7��6�   #��[  6�   6�   �� 5   
   $��© 2024 giáo.làng��6   $
��Left=�6+   $��45��6F   $��
34,611,0,0q�6R   $	��Top=�6f   $	��182��6~   ���#ffff006�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ BookListDataGrid��5      $
��Left=�6-   $	��289��6H   $��
39,320,0,0q�6U   $	��Top=�6i   $	��956��6�      AutoGenerateColumns$ False��6�   $��3��6�   $	   HorizontalScrollBarVisibility$
	 Auto=�6�   $��18(�6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookId+6L     5      $ 	Book Name��6%   $	 140 6U    68   �� *
BookName+6U     5      $ Description��6%   $	 200 6Z    6:   �� *Description+6Z     5      $ 	Pub. Date��6%   $ 90 6\    68   �� *PublicationDate+6\     5       $ Quantity��6%   $ 60 6T    67   �� *
Quantity+6T     5!      $ Price��6%   $ 60 6N    64   �� *Price+6N     5"      $ Author��6%   $	 110 6P    65   �� *Author+6P     5#      $ Category ID��6%   $ 70 6]    6:   �� *BookCategoryId+6]     5$      $ Book Category��6%   $	 200 6k    6<   �� *BookCategory.BookGenreType+6k   5&      5'      5(      