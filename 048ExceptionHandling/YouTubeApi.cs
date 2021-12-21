using System;
using System.Collections.Generic;

namespace _048ExceptionHandling
{
    internal partial class Program
    {
        public class YouTubeApi
        {
            public List<Video> GetVideos(string user)
            {
                try
                {
                    //Access Youtube web service
                    //read the date
                    //create a list of video objects
                }
                catch (Exception ex)
                {
                    //Log them
                    throw new YoutubeException("Couldn't fetch the videos from Youtube. ",ex); //this is how we use custom exception
                }
                return new List<Video>();
            }
        }

    }
}
/*
 sometimes you want to create custom exception 
 */