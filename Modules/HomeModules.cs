// using Nancy;
// using System.Collections.Generic;
// using JobBoard.Objects;
//
//
// namespace JobBoard
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => View["job-post.cshtml"];
//       Post["/post_added"] = _ => {
//       Job newJob = new Job (Request.Form["name"], Request.Form["description"], Request.Form["phone"], Request.Form["email"]);
//       return View["your-post.cshtml", newJob];
//     };
//     Get["/"] = _ => View["job-post.cshtml"];
//     {
//       List<Job> allJobPosts = Job.GetAll();
//       List<string> postInfo = new List<string> {};
//       foreach(Job post in allJobPosts)
//       {
//         postInfo.Add("Name: " + post.GetName());
//         postInfo.Add("Description: " + post.GetDescription());
//         postInfo.Add("Phone: " + post.GetPhone());
//         postInfo.Add("Email: " + post.GetEmail());
//       }
//       return View["all-posts.cshtml", postInfo];
//     };
//    }
//   }
// }
//


using Nancy;
using System.Collections.Generic;
using JobBoard.Objects;


namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["job-post.cshtml"];
      Get["all-posts"] = _ => {
        List<Job> allJobPosts = Job.GetAll();
        List<string> postInfo = new List<string> {};
        foreach(Job post in allJobPosts)
        {
          postInfo.Add("Name: " + post.GetName());
          postInfo.Add("Description: " + post.GetDescription());
          postInfo.Add("Phone: " + post.GetPhone());
          postInfo.Add("Email: " + post.GetEmail());
        }
        return View["all-posts.cshtml", postInfo];
      };
      Post ["/post_added"] = _ => {
        Job newJob = new Job (Request.Form["name"], Request.Form["description"], Request.Form["phone"], Request.Form["email"]);
        return View["your-post.cshtml", newJob];
      };
    }
  }
}
