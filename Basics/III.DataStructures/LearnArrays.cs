using System.Collections;

namespace III.DataStructures;

public class LearnArrays
{
    public static void Init_Arrays()
    {
        // Declaration and Initialization in single expression
        var arrDeclareInit = new int[] { 1, 2, 3, 4, 5 };

        // Compiler Implicitly understand data type in declaration
        // Only works when Initialized with values
        var arrImplicitInit = new[] { 2, 3, 4, 5, 6 };

        // Empty Array with Length only
        var arrOnlyLength = new int[10];

        // Arrays are Zero based index
        arrOnlyLength[0] = 1;
        arrOnlyLength[1] = 2;
    }

    public static void ArrayTypes()
    {
        // Generic Arrays (Type cannot be changed after declaration)
        var arrDeclareInit = new int[] { 1, 2, 3, 4, 5 };
        var arrDeclareStr = new[] { "1", "2", "3", "4", "5", "6" };
        
        // Compiler Error for assigning Different Type than declaration
        // arrDeclareStr[0] = 1;

        // Non Generic, Expandable ArrayList
        // As it stores anything dervied from Object there is Unboxing and boxing involved with Value types 
        ArrayList allTypes = new ArrayList();
        allTypes.Add(1);
        allTypes.Add("2");
    }
}