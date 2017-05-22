using Nancy;
using Triangle.Objects;

namespace Triangle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/type"] = _ => {
        TriangleSides myTriangle = new TriangleSides();
        myTriangle.SetSide1(Request.Query["side1"]);
        myTriangle.SetSide2(Request.Query["side2"]);
        myTriangle.SetSide3(Request.Query["side3"]);
        return View["triangleType.cshtml", myTriangle];
      };
    }
  }
}
