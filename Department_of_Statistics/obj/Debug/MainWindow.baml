   M S B A M L   `   `   `  ����S  ODepartment_of_Statistics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Department_of_StatisticsDepartment_of_Statistics  5   	   )    #Department_of_Statistics.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Department_of_Statistics     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
buttonOpen��5
      $
��Open��6%   $
��Left=�64   $��
578,54,0,0q�6O   $	��Top=�6c   $	��126��6{   $��34��6�   6�   �� 5   
   -   5         ��Name$ textBoxPath��5      $
��Left=�6'   $��23��6B    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��415��6z   $��	99,54,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	datagrid1��5      $
��Left=�6&   $	��241��6A   $��
81,108,0,0q�6N   $	��Top=�6b   $	��650��6z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Department Code��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	dptCode+6Z     5      $ Municipality Code��6%   $	 130 6]    6@   �� *	mcpCode+6]     5      $ Department Name��6%   $	 130 6[    6>   �� *	dptName+6[     5      $ Municipality Name��6%   $	 130 6\    6@   �� *	mcpName+6\     5      $ TMunicipality Type��6%   $	 130 6Z    6A   �� *type+6Z   5      �� 5   
   -   5        $ graphMunicipiesScreen��5      $��Graph��60   $
��Left=�6@   $��440,378,0,0q�6[   $	��Top=�6p   $��74��6�   6�   �� 5   
   -   5        $ begginsLetterScreen��5      $��Report 1��6.   $
��Left=�6A   $��311,378,0,0q�6\   $	��Top=�6q   $��75��6�   6�   5      5      