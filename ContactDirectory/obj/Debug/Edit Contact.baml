   M S B A M L   `   `   `  ����K  GContactDirectory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ContactDirectoryContactDirectory  5   	   #    ContactDirectory.Edit_Contact   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ContactDirectory     5   	     � Title$  Edit_Contact��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5        $
��Menu��5
      $
��Left=�6    $	��Top=�6;   $	��107��6S   $��	10,57,0,0q�6_   $��28��6r   $��14(�6~   $
��Bold"�6�   $��Italic$�6�   6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��
179,10,0,0q�6[   $��41��6o   $	��380��6{   $��24(�6�   $��Italic$�6�   $
��Bold"�6�   ��6�   Z� �� 6�   $�Welcome to ISI Contact ��6�   �� 6�   $��Global Sans Serif)�6�   $�	Directory��6  62  �� 5   
   $
��Left=�6   $
��Wrap=�6/   $)��#Please enter contact number to edit��6C   $	��Top=�6n   $��
204,56,0,0q�6�   $��28��6�   $	��304��6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Contact Number��6C   $	��Top=�6Y   $��179,104,0,0q�6q   $��24��6�   $	��129��6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5   
   -   5         ��Name$ pNumber_Box��5      $
��Left=�6'   $��23��6B    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��313,104,0,0q�6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $	��Top=�6=   $��94��6U   $��503,104,0,0q�6`   $��23��6u   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   6�   �� 5   
   -   5         ��Name$ contactSearch��5      $
��Left=�6+   $
��Wrap=�6F   $	��Top=�6Z   $��204,159,0,0q�6r   $��59��6�   $	��355��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   �� 5   
   -   5        $ after_Search��5      $
��Left=�6*   $
��Wrap=�6E   $4��.Please enter updated first Name and  last name��6Y   $	��Top=�6�   $��179,244,0,0q�6�   $��28��6�   $	��360��6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   $y�Hidden=�6  �� 5   
   -   5        $ fName_Label��5      $
��Left=�6)   $
��Wrap=�6D   $	��Top=�6X   $��179,277,0,0q�6p   $��24��6�   $��97��6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   $y�Hidden=�6�   �� 6�   $�
First Name��6�   6�   �� 5   
   -   5        $ updatedFname��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��313,277,0,0q�6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   �� 5   
   -   5        $ lName_Label��5      $
��Left=�6)   $
��Wrap=�6D   $��	Last Name��6X   $	��Top=�6i   $��179,315,0,0q�6�   $��23��6�   $��97��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   �� 5   
   -	   5        $ updatedLname��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��313,315,0,0q�6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   �� 5   
   -
   5         ��Name$ 	SubmitBtn��5      $��Submit��6$   $
��Left=�65   $	��Top=�6P   $	��109��6h   $��250,368,0,0q�6t   $��25��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   5      5      