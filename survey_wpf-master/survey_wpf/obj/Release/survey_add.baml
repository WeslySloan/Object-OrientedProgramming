   M S B A M L   `   `   `  ���� E  Asurvey_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:survey_wpf
survey_wpf      survey_wpf.survey_add   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:survey_wpf       N� Title$  
survey_add��$	��770��$	��824��.��� .+��� $��Center=�$	��750��.+�� $��0,20,0,0q�.+�� $��60��$	��Top=����	#FF673AB7$��	0,-20,0,0q�.+��� $ ��서브 설문조사 관리��$��Corbel Light)�$��Center=�$��Center=�$��20(�
�������� $	��190��$��0,40,0,0q�
�������.+��� $
��Left=�$��	10,10,0,0q�.+�� $	��0,5q�.+��� $��설문조사 번호��$��Center=��� -    ��Name$ number��$��23��$�� ��$��Center=�$	��120��{�.  $��	-50,0,0,0q�� $	��0,5q�.+��� $��설문조사 제목��$��Center=��� -   $ title��$��23��$�� ��$��Center=�$	��120��{�.  $��	-50,0,0,0q�� $	��0,5q�.+��� $��사용여부��$��Center=��� -    ��Name$
 view��$��Center=�$	��120��{�.  $��	-50,0,0,0q�.@��� $��ON���� $	��OFF��� $	��0,5q�.+��� $��메인 설문조사��$��Center=��� -   $ top_idx��$��23��$��Center=�$	��120��$��	-50,0,0,0q�{�.  �� -   $��찾기��$	��100��$
��Left=�$��Center=�$��	300,0,0,0q�� $	��0,5q�.+��� $��타입��$��Center=��� -   $
 type��$��Center=�$	��120��$��	-50,0,0,0q�{�.  .@��� $��Radio���� $��Check���� $
��Text��� $	��0,5q�$y�Hidden=�.+��� $��Center=�$��현재상태���� -   $ 
modestatus��$��23��$�� ��$��Center=�$��50��{�.  $��30,0,0,0q�� $��Center=�$��60��
�������$	��750��.+��� -    ��Name$ insert��$��입력��$��75��$��30��$��	0,0,400,0q�{�.  �� -	   $ update��$��수정��$��75��$��30��$��	0,0,200,0q�{�.  �� -
   $ delete��$��삭제��$��75��$��30��$��0,0,0,0q�{�.  �� -   $ success��$��확인��$��75��$��30��{�.  $��
0,0,-200,0q��� -   $ cancel��$��취소��$��75��$��30��{�.  $��
0,0,-400,0q�� $��Center=�$��50��
�������$	��750��.+��� -   $ 
searchmode��$��Center=�$��60��$��
-400,0,0,0q� �� SelectedIndex$ 0��.@��� $��전체���� $��번호���� $��제목���� $��설명���� $
��VIEW���� $��설문조사 찾기��$��Center=�$��Center=�$��	0,0,230,0q��� -   $ search_text��$��23��$�� ��$	��120��$��Center=�$��0,0,10,0q�{�.  �� -   $ search��$��검색��$��75��$��Center=�$��30��$��
0,0,-220,0q�� $��Center=�$	��750��.+��� $
��Wrap=�$ ��현재 설문조사 목록��$��20(�&   System.Windows.Controls.DataGrid  -     Name$ 	dataGrid1��$	��300��   
IsReadOnly . 