using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    class Library
    {
        /// <summary>
        /// 현재 텍스트 박스의 행과 열 값을 LineAndColumn타입으로 반환
        /// </summary>
        /// <param name="objTextBox">텍스트 박스</param>
        /// <returns>LineAndColumn Type</returns>
        public static LineAndColumn GetLineAndColumn(
            System.Windows.Forms.TextBox objTextBox)
        {
            // 현재 커서의 위치
            int intCursorPosition = objTextBox.SelectionStart;
            // 시작 위치 변수
            int intStartIndex = 0;

            //반환형 변수
            LineAndColumn rtnVal;
            rtnVal.Line = 1;

            if(intStartIndex == 0)
            {
                rtnVal.Column = 1;
                return rtnVal;
            }

            while(true)
            {
                intStartIndex = objTextBox.Text.IndexOf('\n', intStartIndex + 1);

                if( (intStartIndex > intCursorPosition) ||
                    intStartIndex == -1)
                {
                    break;
                }
                else
                {
                    rtnVal.Line++;
                }
            }

            if(rtnVal.Line==1)
            {
                rtnVal.Column = intCursorPosition + 1;
            }
            else
            {
                for(int i=0; i < rtnVal.Line -1; i++)
                {
                    intCursorPosition -= objTextBox.Lines[i].Length + 2;
                }
                rtnVal.Column = intCursorPosition + 1;

            }           

            return rtnVal;
        }

        // 행과 열을 묶어서 관리하는 구조체
        public struct LineAndColumn
        {
            public int Line; // 행
            public int Column; // 열
        }
    }
}
