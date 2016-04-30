using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //a delegate is a type... just like a string, int, object, etc...
    //a delegate is a varible that can only point to a method with a matching signature
    //below I define a delegate type that can reference a method that takes a single string parameter and returns a string 
    private delegate string GetAnswer(string question);
    private string input, result = "";
    //I have defined my delegate type above so now I can declare a delagate variable - 
    //this one I named functionReference to remind me that this delegate variable will point to a function or method
    private GetAnswer functionReference;

    protected void Page_Load(object sender, EventArgs e)
    {
        //at Page_Load I point the functionReference delegate variable to a method with matching signature
        functionReference = My_DelegateMethod;
    }

    protected void cmdClickMe_Click(object sender, EventArgs e)
    {
        input = txtInput.Text;
        result = functionReference(input);
        lblResult.Text = result;
    }

    //this is one of the methods my delegate variable can reference
    private string My_DelegateMethod(string parameterString)
    {
        string answer = "";
        if (parameterString == "story bud?")
        {
            answer = "You looking?";
        }
        else
        {
            answer = "Keep walkin'";
        }
        return answer;
    }

    //this is another method that can be referenced by the delegate variable
    private string AreWeThereYet(string question)
    {
        string answer = "";
        if (question == "Are we there yet?")
        {
            answer = "Almost there";
        }
        else
	    {
                answer = "Where are we?";
	    }
        return answer;
    }
    protected void cmdWhereAreWe_Click(object sender, EventArgs e)
    {
        //since this is a different question we now wich to call a different method
        //so I point functionReference at the method I want to run 
        functionReference = AreWeThereYet;
        input = txtAreWeTherYet.Text;
        result = functionReference(input);
        lblResult.Text = result;
    }
}