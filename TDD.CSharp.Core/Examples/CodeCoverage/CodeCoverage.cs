using System;

namespace TDD.CSharp.Core.Examples.CodeCoverage
{
    public class CodeCoverage
    {
       
        public void LineVsBranchCoverage(Boolean condition)
        {                           //line 1 
            if (condition)          //line 2 branch 1
            {                       //line 3
                Line();             //line 4
                Line();             //line 5
            }                       //line 6
            else
            {                       //line 7 branch 2
                Line();             //line 8
            }                       //line 9
        }                           //line 10
        public void Line()
        {                           //line 11
        }                           //line 12
    }
}
