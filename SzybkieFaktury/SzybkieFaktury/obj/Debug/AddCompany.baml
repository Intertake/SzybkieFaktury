   M S B A M L   `   `   `  ����I  ESzybkieFaktury, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SzybkieFakturySzybkieFaktury  5   	       SzybkieFaktury.AddCompany   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SzybkieFaktury     5   	     � Title$  
AddCompany��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��Dodaj firme��5
      $
��Left=�6'   $��133,207,0,0q�6B   $	��Top=�6W   $	��120��6o   $��24��6�   �� 5   
   $	��NIP��6   $
��Left=�6   $��	10,10,0,0q�69   $	��Top=�6L   �� 5   
   $��Nazwa��6   $
��Left=�6    $��	10,41,0,0q�6;   $	��Top=�6N   $��55��6f   �� 5   
   $��Miasto��6   $
��Left=�6!   $��	10,72,0,0q�6<   $	��Top=�6O   �� 5   
   $��Ulica��6   $
��Left=�6    $��
10,103,0,0q�6;   $	��Top=�6O   �� 5   
   $��Numer budynku��6   $
��Left=�6(   $��
10,134,0,0q�6C   $	��Top=�6W   �� 5   
   $��Kod pocztowy��6   $
��Left=�6'   $��
10,165,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ AddNip_TextBox��5      $
��Left=�6*   $��23��6E   $��
133,13,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   $��example��6�   �� 5   
   -   5        $ AddName_TextBox��5      $
��Left=�6+   $��23��6F   $��
133,44,0,0q�6R   $
 Wrap=�6f   $��example��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ AddCity_TextBox��5      $
��Left=�6+   $��23��6F   $��
133,72,0,0q�6R   $
 Wrap=�6f   $��example��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ AddStreet_TextBox��5      $
��Left=�6-   $��23��6H   $��133,103,0,0q�6T   $
 Wrap=�6i   $��example��6}   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ AddBuilding_TextBox��5      $
��Left=�6/   $��23��6J   $��133,137,0,0q�6V   $
 Wrap=�6k   $��example��6   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ AddPostcode_TextBox��5      $
��Left=�6/   $��23��6J   $��133,168,0,0q�6V   $
 Wrap=�6k   $��example��6   $	��Top=�6�   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$  AddingCompany_DataGridView��5      $
��Left=�67   $	��256��6R   $��
299,13,0,0q�6_   $	��Top=�6s   $	��483��6�   6�   �� 5   
   -	   5         ��Name$ DelCompany_Button��5      $��Usuń firmę��6,   $
��Left=�6A   $��688,274,0,0q�6\   $	��Top=�6q   $��94��6�   $��32��6�   �� 5   
   -
   5        $ EditCompany_Button��5      $��Edytuj firmę��6-   $
��Left=�6D   $��133,236,0,0q�6_   $	��Top=�6t   $	��120��6�   $��26��6�   6�   5      5      