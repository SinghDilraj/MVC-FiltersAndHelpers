﻿using System;
using System.Web.Mvc;

namespace MVC_FiltersAndHelpers.Models.Helpers
{
    public static class ExtensionMethods
    {
        //html helper method return mvc html string of bootstrap model snippet
        public static MvcHtmlString BootstrapModal(this HtmlHelper html, string title, string body)
        {
            Guid id = Guid.NewGuid();

            return MvcHtmlString.Create($@"<!-- Button trigger modal -->
                                            <button type='button' class='btn btn-primary' data-toggle='modal' data-target='#{id.ToString()}'>
                                              Launch modal
                                            </button>

                                            <!-- Modal -->
                                               <div class='modal fade' id='{id.ToString()}' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                                                  <div class='modal-dialog' role='document'>
                                                    <div class='modal-content'>
                                                      <div class='modal-header'>
                                                        <h5 class='modal-title' id='exampleModalLabel'>{title}</h5>
                                                        <button type = 'button' class='close' data-dismiss='modal' aria-label='Close'>
                                                          <span aria-hidden='true'>&times;</span>
                                                        </button>
                                                      </div>
                                                      <div class='modal-body'>
                                                        {body}
                                                      </div>
                                                      <div class='modal-footer'>
                                                        <button type='button' class='btn btn-secondary' data-dismiss='modal'>Close</button>
                                                      </div>
                                                    </div>
                                                  </div>
                                                </div>");
        }

        //Boolean Helper Method --> Return string yes or no if its true or false respectively
        public static string ToYesOrNo(this bool boolean)
        {
            if (boolean)
            {
                return "Yes";
            }
            else if (!boolean)
            {
                return "False";
            }
            else
            {
                return "Unidentified";
            }
        }
    }
}