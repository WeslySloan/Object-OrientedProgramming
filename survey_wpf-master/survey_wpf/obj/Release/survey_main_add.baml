   M S B A M L   `   `   `  ���� E  Asurvey_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:survey_wpf
survey_wpf       survey_wpf.survey_main_add   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:survey_wpf       N� Title$  survey_main_add��.��� .+��� $��Center=�$	��750��.+�� $��60��$	��Top=����	#FF673AB7$��0,0,0,0q�.+��� $ ��메인 설문조사 관리��$��Corbel Light)�$��Center=�$��Center=�$��20(�
��������� $	��750��$	��200��
�������.+�� $��10,15q�.+��� $��설문조사 번호��$��Center=��� -    ��Name$ number��$��23��$�� ��$
��Left=�$��Center=�$	��120��{�.  $��	100,0,0,0q�� $
��10,0q�.+��� $��설문조사 제목��$��Center=��� -   $ title��$��23��$�� ��$
��Left=�$��Center=�$	��120��{�.  $��	100,0,0,0q�� $��10,10q�.+��� $��사용여부��$��Center=��� -    ��Name$
 view��$
��Left=�$��Center=�$	��120��{�.  $��	100,0,0,0q�.@��� $��ON���� $	��OFF��� $
��10,0q�.+��� $��설문조사 설명��$��Center=��� -   $
 info��$��23��$�� ��$
��Left=�$��Center=�$	��200��{�.  $��	100,0,0,0q�� $��Center=�$��60��
�������$	��750��$	��0,0q�.+��� -    ��Name$ insert��$��입력��$��75��$��30��$��	0,0,400,0q��� -   $ update��$��수정��$��75��$��30��$��	0,0,200,0q��� -   $ delete��$��삭제��$��75��$��30��$��0,0,0,0q��� -   $ success��$��확인��$��75��$��30��{�.  $��
0,0,-200,0q��� -	   $ cancel��$��취소��$��75��$��30��{�.  $��
0,0,-400,0q�� $��Center=�$	��750��.+��� $
��Wrap=�$ ��현재 설문조사 목록��$��20(�&   System.Windows.Controls.DataGrid  -
     Name$ 	dataGrid1��$	��300��   
IsReadOnly . 