   M S B A M L   `   `   `  ���� E  Asurvey_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:survey_wpf
survey_wpf      survey_wpf.survey_item   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:survey_wpf       N� Title$  survey_item��.��� .+��� $��Center=�.+�� .+��� $ ��서브 설문조사 목록��$	��750��$	��300��$��Center=�.���� .+�� $��Center=�$��Center=�$��0,0,0,10q�.+��� -    ��Name$ 
searchmode��$��60��$��
-200,0,0,0q� �� SelectedIndex$ 0��.@��� $��전체���� $��번호���� $��제목���� $��설명���� $
��VIEW���� -    ��Name$ 	searchbox��$��23��$�� ��$	��120��{�.  �� -   $��검색��$��60��$��25��$��
0,0,-210,0q�� .+�&   System.Windows.Controls.DataGrid  -     Name$ 
surveylist��$	��200��   
IsReadOnly . � $��0,0,0,0q�.+��� -    ��Name$ itembox��$��항목 생성/관리��$	��750��$	��450��{�.  .���� .+��  � ColumnDefinitions �� $	��400 ��� $��* � � RowDefinitions �� $	��110 ��� $��* �.+��� .+�� $	��0,5q�.+��� $��번호���� -   $ number��$
��Left=�$�� ��$��65,0,0,0q�$��50��{�.  �� -   	 ��Name$	 Nickname_label��$��별명��$��	285,0,0,0q��� -   $ Nickname��$��60��$��	300,0,0,0q�{�.  � $	��0,5q�.+��� $��선택유형���� -	   $
 type��{�.  $��80��$
��Left=�$��65,0,0,0q�.@��� $��Radio���� $��Check���� $
��Text��� -
   
 �Name$
 textbox_height��$��Center=�$y�Hidden=�.+��� $��박스 넓기��$��	260,0,0,0q��� -   $ mheight��$�� ��$��60��$��	300,0,0,0q�� $	��0,5q�.+��� $��질문내용���� -   $ Content��{�.  $�� ��$��	-70,0,0,0q�$	��200���� $	��뷰��$��	295,0,0,0q��� -   $ viewbox��{�.  $��	300,0,0,0q�$��60��.@��� $��ON���� $	��OFF���� $��1��.+�� $	��0,0q�$��Right=�.+��� $#��선택한 설문조사 정보��$	��105��$	��300��.���� .+��� -    ��Name$ survey_number��$��없음���� -   $ survey_title��$�� ���� -   $ survey_info��$�� ��� $��	0,10,0,10q�.+�� $y�Hidden=�.+��� $��현재상태���� -   $ 
modestatus��$��23��$�� ��$
��Left=�$��Center=�$��50��{�.  $��65,0,0,0q��� -    ��Name$ insertB��$��입력��$��60��$��25��$��	0,0,300,0q��� -   $ updateB��$��수정��$��60��$��25��$��	0,0,150,0q��� -   $ deleteB��$��삭제��$��60��$��25��$��0,0,0,0q��� -   $ successB��$��확인��$��60��$��25��$��
0,0,-150,0q�{�.  �� -   $ cancelB��$��취소��$��60��$��25��$��
0,0,-300,0q�{�.  � .+�  -   $ itemlist��$	��250�� . 