   M S B A M L   `   `   `  ����I  ESzybkieFaktury, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SzybkieFakturySzybkieFaktury  5   	       SzybkieFaktury.AddInvoice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SzybkieFaktury     5   	     � Title$  
AddInvoice��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��	Przedmiot��6   $
��Left=�6$   $��
10,226,0,0q�6?   $	��Top=�6S   $��27��6k   $	��175��6w   �� 5   
   -   5         ��Name$ 	Item_text��5      $
��Left=�6%   $��25��6@   $��
10,253,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��258��6�   �� 5   
   $��Ilość��6   $
��Left=�6    $��
10,278,0,0q�6;   $	��Top=�6O   $��23��6g   $	��102��6s   �� 5   
   -   5        $ Quantity_text��5      $
��Left=�6)   $��23��6D   $��
10,306,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $��
Cena Netto��6   $
��Left=�6%   $��
10,329,0,0q�6@   $	��Top=�6T   $��27��6l   $	��127��6x   �� 5   
   -   5        $ 
netto_text��5      $
��Left=�6&   $��23��6A   $��
10,361,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ invoiceGoods_GridView��5      $
��Left=�62   $	��211��6M   $��	10,10,0,0q�6Z   $	��Top=�6m   $	��419��6�   �� 5   
   -   5         ��Name$ AddItemToInvoice_button��5      $��Dodaj do faktury��62   $
��Left=�6M   $��
10,389,0,0q�6h   $	��Top=�6|   $	��161��6�   6�   �� 5   
   -   5        $ close_invoice��5      $��Zamknij fakturę��6(   $
��Left=�6B   $��633,382,0,0q�6]   $	��Top=�6r   $	��149��6�   $��27��6�   �� 5   
   $��Data płatności��6   $
��Left=�6)   $��
450,10,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ 0.381,0.392&�6p   $��28��6�   $	��127��6�   �� 5   
   -   5        $ Payment_Text��5      $
��Left=�6(   $��26��6C   $��
450,38,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��146��6�   �� 5   
   -   5        $ auth_recieve��5      $
��Left=�6(   $��23��6C   $��450,109,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��173��6�   �� 5   
   $!��Osoba uprawniona do odbioru��6   $
��Left=�66   $��
450,78,0,0q�6Q   $	��Top=�6e   5      5      