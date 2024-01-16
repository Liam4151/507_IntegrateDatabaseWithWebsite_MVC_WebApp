using TypicalTools.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace TypicalTools.Controllers
{
    // Controller class for comments
    public class CommentController : Controller
    {
        private readonly ContextModel _mainContextModel;

        // Constructor for comments 
        public CommentController(ContextModel commentContextModel)
        {
            _mainContextModel = commentContextModel;
        }

        // Sends Http GET request to server that retrieves comment list using id
        [HttpGet]
        public IActionResult CommentList(int id)
        { 
            // Retrieves comments in list based on the product code
            var comments = _mainContextModel.Comments.Where(a => a.ProductCode == id).ToList();
            // Displays list of comments for the product 
            return View(comments);
        }
         
        // Sends Http GET method that retrieves comment data to create a comment 
        [HttpGet]
        public IActionResult CreateComment(int productCode)
        {
            // Uses comment model for new comment 
            Comment comment = new Comment();
            // Comment is assigned to the product's product code 
            comment.ProductCode = productCode;
            // Displays the create comment view for that product
            return View(comment);
        }

        // Sends HTTP Post Method that creates a comment for a product
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            if (string.IsNullOrEmpty(comment.CommentText))
            {
                ModelState.AddModelError("CommentText", "Error: Comment cannot be empty.");
                return View(comment);
            }
            else
            {

                _mainContextModel.Comments.Add(new Comment
                {
                    CommentText = comment.CommentText,
                    ProductCode = comment.ProductCode,
                    SessionId = HttpContext.Session.Id

                });

                // Session id set and comment text value added to create session
                HttpContext.Session.SetString("CommentText", comment.CommentText);
                _mainContextModel.SaveChanges();

                return RedirectToAction("Index", "Product");
            }
        }

        // Sends HTTP Get request to server that retrieves Comment Id so it can be deleted
        [HttpGet]
        public IActionResult DeleteComment(int commentId)
        {
            var comment = _mainContextModel.Comments.FirstOrDefault(a => a.CommentId == commentId);
            return View(comment);
        }

        // Sends HTTP Post request that Deletes that comment based on its commentId
        [HttpPost]
        public IActionResult ConfirmDeleteComment(int commentId)
        {
            // Retrieves commentId
            var comment = _mainContextModel.Comments.FirstOrDefault(a => a.CommentId == commentId);
            // Checks the authentication status and authenticates user
            string authStatus = HttpContext.Session.GetString("Authenticated");
            bool isAdmin = !String.IsNullOrWhiteSpace(authStatus) && authStatus.Equals("True");

            // Checks if the session is administrator authorised 
            if (comment.SessionId == HttpContext.Session.Id || isAdmin)
            {
                // Removes the comment
                _mainContextModel.Comments.Remove(comment);
            }

            // Saves changes to the product's comments 
            _mainContextModel.SaveChanges();
            // Displays the original comment list for user (based on product)
            return RedirectToAction("CommentList", "Comment", new { id = comment.ProductCode });
        }

        [HttpGet]
        public IActionResult UpdateComment(int commentId)
        {
            // Retrieves tbe comment Id
            var comment = _mainContextModel.Comments.FirstOrDefault(a => a.CommentId == commentId);
            // Displays update comment page
            return View (comment);
        }

        // Sends Http Post request that updates the comment
        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
        {
            // Updates the comment
            _mainContextModel.Comments.Update(comment);
            // Saves the changes to comment list 
            _mainContextModel.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}
