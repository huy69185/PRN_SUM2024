   M S B A M L   `   `   `  ����K  GBookManagementUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PEPE  5   	       PE.MainScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PE     5   	   -   5          � Title$!  Main Book Management Window��5   	   $	��685��6-   $
��1220��6:   $��Arial)�6G   $��14(�6Z   ���	#FFD4F7D4 � WindowStartupLocation$ CenterScreen=�6   .��5	      � .+�5
   
   �� $
��Left=�6   $��95��6/   $��
39,144,0,0q�6;   
���   �$	��Top=�6^   $
��1145��6v   
����� �6�   �� 5   
   $��	Book Name��6   $
��Left=�6$   $��45��6?   $��
73,174,0,0q�6K   $	��Top=�6_   $	��107��6w   $��22(�6�   �� 5   
   -   5         ��Name$ BookNameTextBox��5      $
��Left=�6+   $��45��6F   $��193,170,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6|   $	��275��6�   $��0��6�   �� 5   
   $��	Book Desc��6   $
��Left=�6$   $��45��6?   $��514,174,0,0q�6K   $	��Top=�6`   $	��107��6x   $��22(�6�   �� 5   
   -   5        $ DescriptionTextBox��5      $
��Left=�6.   $��45��6I   $��628,170,0,0q�6U   $
 Wrap=�6j   $	��Top=�6   $	��275��6�   $��1��6�   �� 5   
   -   5         ��Name$ SearchButton��5      $��Search��6'   $
��Left=�68   $��50��6S   $��989,166,0,0q�6_   $	��Top=�6t   $	��165��6�   $��2��6�   $��22(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BookListDataGrid��5      $
��Left=�6-   $	��309��6H   $��
39,307,0,0q�6U   $	��Top=�6i   $	��930��6�      AutoGenerateColumns$ False��6�   $��3��6�   $   HorizontalScrollBarVisibility$
 Auto=�6�   $��18(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 30 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookId+6L     5      $	 	Book Name��6%   $	
 140 6U    68   �� *
BookName+6U     5      $	 Description��6%   $	
 140 6Z    6:   �� *Description+6Z     5      $	 	Pub. Date��6%   $	
 100 6\    68   �� *PublicationDate+6\     5      $	 Quantity��6%   $
 80 6T    67   �� *
Quantity+6T     5      $	 Price��6%   $
 70 6N    64   �� *Price+6N     5      $	 Author��6%   $
 70 6P    65   �� *Author+6P     5      $	 Category ID��6%   $	
 110 6]    6:   �� *BookCategoryId+6]     5      $	 Book Category��6%   $	
 200 6k    6<   �� *BookCategory.BookGenreType+6k   5      �� 5   
   -   5        $ CreateButton��5      $��Create��6'   $
��Left=�68   $��
1020,0,0,0q�6S   $��Center=�6g   $��56��6�   $	��134��6�   $��22(�6�   6�   �� 5   
   -   5        $ UpdateButton��5      $��Update��6'   $
��Left=�68   $��1020,384,0,0q�6S   $	��Top=�6i   $��56��6�   $	��134��6�   $��22(�6�   6�   �� 5    
   -   5        $ DeleteButton��5       $��Delete��6'   $
��Left=�68   $��1020,461,0,0q�6S   $	��Top=�6i   $��56��6�   $	��134��6�   $��22(�6�   6�   �� 5!   
   -	   5        $ 
QuitButton��5!      $
��Quit��6%   $
��Left=�64   $��1020,560,0,0q�6O   $	��Top=�6e   $��56��6}   $	��134��6�   $��22(�6�   6�   �� 5"   
   $��Book Management��6   $
��Left=�6*   $��	34,50,0,0q�6E   $	��Top=�6X   $��70(�6p   �� 5#   
   $��	Book List��6   $
��Left=�6$   $��
39,265,0,0q�6?   $	��Top=�6S   $��22(�6k   5$      5%      