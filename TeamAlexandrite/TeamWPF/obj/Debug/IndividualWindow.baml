   M S B A M L   `   `   `  ����I  ECourierManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:CourierManager;assembly=CourierManagerCourierManager  5   	    TeamWPF   TeamWPF.IndividualWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Flocal4clr-namespace:CourierManager;assembly=CourierManager     5   	   -   5        $��individualform��5   ,     � Title$  IndividualWindow��5   	   $	��350��6"   $	��500��6/   
�������
���   � � Topmost . .��5      � -   5        $��IndividualGridRoot��5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   5      �� 5      $	��370 �6   5      .+�5   
   �� -   5        $��IndividualForm��5      $��1��6&   $��20(�66   $��Individual Form��6D   $y�Visible=�6^   o� 5   
   -   5        $��RecipientTypeMenu��5      $	��370��6   $��20(�64   $��Center=�6B   $��1��6_   $y�	Collapsed=�6o   
�������.@�5      m� -   5        $��RecipientMenuHeader��5   #   $	��370��6   $��Client Type��6>   .@�5      m� -   5        $��IndividualRecipient��5      $��
Individual��66   6J   m� 5      -   5        $��CompanyRecipient��5      $��Company��63   6D   5      5       �� 5!   
   -   5        $"��IndividualRecipientFirstName��5"      $��1��5!      
���   �$��1q�5$      $��First Name:��5%      $y�	Collapsed=�5&      �� 5'   
   -	   5        $!��IndividualRecipientLastName��5(      $��2��5'      
���   �$��1q�5*      $��
Last Name:��5+      $y�	Collapsed=�5,      �� 5-   
   -
   5        $ ��IndividualRecipientAddress��5.      $��3��5-      
���   �$��1q�50      $��Adress:��51      $y�	Collapsed=�52      �� 53   
   -   5        $��IndividualRecipientPhone��54      $��4��53      
���   �$��1q�56      $��Phone:��57      $y�	Collapsed=�58      �� 59   
   -   5        $'��!IndividualRecipientFirstNameInput��5;      $��1��59      $��1��5:      $��Black"�5<      $��20(�5=      
�������$y�	Collapsed=�5?      �� 5A   
   -   5        $&�� IndividualRecipientLastNameInput��5C      $��2��5A      $��1��5B      $��Black"�5D      $��20(�5E      
�������$y�	Collapsed=�5G      �� 5I   
   -   5        $%��IndividualRecipientAddressInput��5K      $��3��5I      $��1��5J      $��Black"�5L      $��20(�5M      
�������$y�	Collapsed=�5O      �� 5Q   
   -   5        $#��IndividualRecipientPhoneInput��5S      $��4��5Q      $��1��5R      $��Black"�5T      $��20(�5U      
�������$y�	Collapsed=�5W      �� 5Y   
   -   5        $��
SenderType��5Z      $y�Visible=�5[      
�������$��SENDER��5]      $��20(�5^      $��Italic$�5_      �� 5a   
   -   5        $��RecipientType��5b      $y�	Collapsed=�5c      
�������$��	Recipient��5e      $��20(�5f      $��Italic$�5g      �� 5i   
   -   5        $��IndividualFirstName��5n      
���   �$��1q�5j      $��2��5k      $��0��5l      $y�Visible=�5m      $��First Name:��5o      �� 5q   
   -   5        $��IndividualLastName��5w      
���   �$��1q�5s      $��3��5t      $��0��5u      $y�Visible=�5v      $��
Last Name:��5x      �� 5y   
   -   5        $��IndividualAddress��5      
���   �$��1q�5{      $��4��5|      $��0��5}      $y�Visible=�5~      $��Address:��5�      �� 5�   
   -   5        $��IndividualID��5�      
���   �$��1q�5�      $��1��5�      $��0��5�      $y�Visible=�5�      $��
ID Number:��5�      �� 5�   
   -   5        $��IndividualPhone��5�      
���   �$��1q�5�      $��5��5�      $��0��5�      $y�Visible=�5�      $��Phone:��5�      �� 5�   
   -   5        $��IndividualNameInput��5�      $y�Visible=�5�      $��Black"�5�      $��20(�5�      
�������$�� ��5�       �� TextDecorations$  {�5�      $��2��5�      $��1��5�      �� 5�   
   -   5        $��IndividualLastNameInput��5�      $y�Visible=�5�      $��Black"�5�      $��20(�5�      
�������$�� ��5�      $  {�5�      $��3��5�      $��1��5�      �� 5�   
   -   5        $��IndividualAddressInput��5�      $y�Visible=�5�      $��Black"�5�      $��20(�5�      
�������$�� ��5�      $  {�5�      $��4��5�      $��1��5�      �� 5�   
   -   5        $��IndividualIDNumberInput��5�      $y�Visible=�5�      $��Black"�5�      $��20(�5�      
�������$�� ��5�      $  {�5�      $��1��5�      $��1��5�      5�      �� 5�   
   -   5        $��IndividualPhoneInput��5�      $y�Visible=�5�      $��Black"�5�      $��20(�5�      
�������$�� ��5�      $  {�5�      $��5��5�      $��1��5�      �� 5�   
   -   5        $��CompanyRecipientName��5�      $��1��5�      $��Company Name:��5�      
���   �$��1q�5�      $y�	Collapsed=�5�      �� 5�   
   -   5        $��CompanyRecipientAddress��5�      $��2��5�      $��Address:��5�      
���   �$��1q�5�      $y�	Collapsed=�5�      �� 5�   
   -   5        $��CompanyRecipientPhone��5�      $��3��5�      $��Phone:��5�      
���   �$��1q�5�      $y�	Collapsed=�5�      �� 5�   
   -   5        $��CompanyRecipientNameInput��5�      $��1��5�      $��1��5�      $��Black"�5�      $��20(�5�      
�������$y�	Collapsed=�5�      �� 5�   
   -    5        $"��CompanyRecipientAddressInput��5�      $��2��5�      $��1��5�      $��Black"�5�      $��20(�5�      
�������$y�	Collapsed=�5�      �� 5�   
   -!   5        $ ��CompanyRecipientPhoneInput��5�      $��3��5�      $��1��5�      $��Black"�5�      $��20(�5�      
�������$y�	Collapsed=�5�      �� 5�   
   -"   5        $��SubmitIndividualData��5�   3   $��SUBMIT��6O   
�������$��20(�6y   $
��Left=�6�   $��30��6�   $��95��6�   $��1��6�   $��199,51,0,-50q�6�   $��5��6�    J� RenderTransformOrigin$ 	0.484,0.2&�6�   5�      5�      