   M S B A M L   `   `   `  ����F  Btext_editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:text_editortext_editor  5   	       text_editor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:text_editor     5   	   -   5          �Name$  Window��5   	    � Title$ Text Editor��5   	   $��478.4��6   $��934.4��6,   .��5	      � $��	0,0,0,1.8q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $
��142* �6   .+�5   
   o� $
��Left=�6   $��21��6*   $	��Top=�66   $	��794��6N   $��0��6Z   $��2��6g   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$
 Save��5      $
��Save��6)   5      m� 5      -   5        $
��Open��5      5      m� 5      -   5        $��Close��5      5      m� 5      -   5        $
��Exit��5      5      5      m� 5      $
��Edit��6   .@�5      m� -   5        $
��Copy��5      6>   m� 5      -   5        $��Paste��5      6@   m� 5       -   5        $	��Cut��5       6<   5!      5"      �� 5#   
   -	   5         ��Name$ TextBox��5#      $
��Left=�6#   $	��416��6>   $��	0,0.2,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��918��6�    � Cursor$ IBeam��6�   $��1��6�   5%      5&      