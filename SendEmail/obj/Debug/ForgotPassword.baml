   M S B A M L   `   `   `  ����  	SendEmail    SendEmail.ForgotPassword   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5   	   $��Segoe UI Emoji)�5	   	    � Title$ ForgotPassword��5
   	   $	��700��6    $	��500��6-   .��5      � $��0,0,0,1q�6   .+�5   
   �� $	��350��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��400��6   $	��383��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V    �� RadiusX$ 10��6c   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 15Q�6#   
   	Direction$
 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      �� 5   
   $	��Top=�6   $��
10,10,10,0q�6-   $	��648��6A   .+�5      � $��Bottom=�6   $
��0,50q�6.   $	��385��6<   .+�5      �� $��Center=�6   $��68,185,72,-152q�68   $	��267��6P   .+�5      �� $��FORGOT PASSWORD��6   $��Center=�66   $	��Top=�6S   $	��-50q�6k   
�������$��18(�6�   �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ 	Email_Txt��5   "   $
��Left=�65   $	��244��6P   $
��0,10q�6\   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6j    %  !MaterialDesignFloatingHintTextBox#��[  6�   $��Champagne & Limousines)�6�   $��18(�6�   �� 5       -   5        $��	Check_Btn��5    !   $
��Left=�62   $��2q�6M   $��CHECK��6X   6h   5!      G� 5"      -   5         G�Name$ OldPassword_Txt��5"   "   $
��0,10q�6;   $ OLD PASSWORD��6I    ) %MaterialDesignFloatingHintPasswordBox#��[ 6w   $��Champagne & Limousines)�6�   $��18(�6�   G� 5#      -   5        $ NewPassword_Txt��5#   "   $
��0,10q�6;   $ NEW PASSWORD��6I   #��[ 6w   $��Champagne & Limousines)�6�   $��18(�6�   G� 5$      -   5        $ RetypePassword_Txt��5$   "   $
��0,10q�6>   $ RE-TYPE NEW PASSWORD��6L   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   5%      5&      5'      �� 5(   
   -   5        $��	Login_Btn��5(      $	��200��6"   $��50��6.   $��Center=�6:   $��Bottom=�6W   $��-160,100,0,55q�6r   $��CHANGE PASSWORD��6�   �� 5)   
   -   5        $��
Cancel_Btn��5)      $	��150��6#   $��50��6/   $��Center=�6;   $��Bottom=�6X   $��210,100,0,55q�6s   $��CANCEL��6�   6�   �� 5*   
   $��Assets/Key.png��6   $	��100��6(   $	��100��64   $	��Top=�6A   $��30q�6Y   5+      5,      