using System;
using System.Collections.Generic;

namespace WebApplication9.Models
{
    public class CommentModel
    {
        public string Author { get; set; } = "Anonymous";
        public string Text { get; set; } = string.Empty;
        public DateTime PostedAt { get; set; } = DateTime.Now;
    }

    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public List<CommentModel> Comments { get; set; } = new();
    }
    public static class ProjectData
    {
        public static List<Project> Projects { get; } = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "Student Management System – Procedural Core",
                Description = "A foundational C# procedural programming project implementing core student records management logic.",
                Details = "Includes procedural data processing, console-based user menus, structural input validation, and basic record manipulation algorithms.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT31E2_Prelim_H1_GOMEZANGELICA.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Student+Management+System",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 2,
                Title = "GitHub Desktop + Visual Studio + C# FizzBuzz Challenge",
                Description = "Hands-on challenge integrating Visual Studio C# development with GitHub Desktop workflow automation.",
                Details = "Focuses on version control fundamentals, feature branch management, commit hygiene, and implementing the classic FizzBuzz algorithmic challenge in C#.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT31E2_PRELIM_A1_GOMEZANGELICAMARIE.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=FizzBuzz+Challenge",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 3,
                Title = "Visual Studio Git Repository + GitHub Desktop + C# Calculator Challenge",
                Description = "A C# calculator application constructed with integrated Git source control tracking in Visual Studio.",
                Details = "Demonstrates arithmetic operator parsing, basic error handling, unit input validation, and local-to-remote Git repository synchronization workflows.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT31E2_PRELIM_A2_GOMEZANGELICAMARIE.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Calculator+Challenge",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 4,
                Title = "PRELIM ACTIVITY 3",
                Description = "Hands-on programming task focused on structural syntax, control flow logic, and function definition.",
                Details = "Covers essential modular programming practices, structured logic flows, and function parameters in C#.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT31E2_Prelim_H1_GOMEZANGELICA.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Prelim+Activity+3",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 5,
                Title = "File Ingestion Engine",
                Description = "Data ingestion module capable of parsing, processing, and validating structured external file inputs.",
                Details = "Implemented file stream operations, exception handling, string parsing routines, and structured data serialization in C#.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT31E2_PRELIM_H2_GOMEZ_ANGELICA.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=File+Ingestion+Engine",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 6,
                Title = "Transport Resolver Challenge",
                Description = "Algorithmic routing module designed to process and resolve transport route configurations.",
                Details = "Focuses on data structure optimization, conditional branch execution, and structured problem-solving techniques for network and routing challenges.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/BSIT_31E2_PRELIM_Q1_GOMEZ-ANGELICA.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Transport+Resolver",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 7,
                Title = "PRELIM - Activity 3 (HTTP Server)",
                Description = "Low-level custom HTTP Web Server implementation built from foundational socket communication concepts.",
                Details = "Parses incoming HTTP request headers, handles standard request verbs, routes resource requests, and serves dynamic or static web responses over TCP listeners.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/HTTP-SERVER.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=HTTP+Server",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 8,
                Title = "Website Using ASP.NET Core MVC",
                Description = "Web application leveraging the Model-View-Controller design pattern in ASP.NET Core.",
                Details = "Features structured routing controllers, strongly-typed Razor view layouts, custom CSS styling, and modular component design.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_Midterm_A1_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=ASP.NET+Core+MVC",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 9,
                Title = "Midterm - Activity 2",
                Description = "Intermediate web application development assignment focusing on MVC framework components.",
                Details = "Demonstrates controller action handling, view data passing via ViewData/ViewBag, layout inheritance, and form post handlers.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_Midterm_A1_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Midterm+Activity+2",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 10,
                Title = "ASP.NET Core MVC Model Binding Tutorial Video",
                Description = "Demonstrational project accompanied by a tutorial on model binding in ASP.NET Core MVC.",
                Details = "Covers automatic request data mapping, complex object binding from HTTP POST/GET requests, model validation attributes, and custom input formatting.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_BSIT31E2_GOMEZ_ANGELICAMARIE.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Model+Binding+Tutorial",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 11,
                Title = "The Protected Youtube Playlist Builder",
                Description = "A secured web application designed to curate, organize, and stream media playlists.",
                Details = "Includes role-based page protection, custom media input validation, session tracking, and playlist management views.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_MIDTERM_Q2_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Playlist+Builder",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 12,
                Title = "Gym Member Attendance Monitoring System Specification",
                Description = "A web application built with ASP.NET Core MVC for tracking gym membership and visit logs.",
                Details = "Features membership type categorization (Senior, Student, Standard), member visit recording, account authentication cards, and customized Razor views.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_MIDTERM_EXAM_-7-_-Gomez_Angelica-.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Gym+Attendance+System",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 13,
                Title = "Retro Bytes - Point of Sale (POS) Web Application",
                Description = "Point of Sale (POS) system built with ASP.NET Core MVC featuring a monochrome retro aesthetic.",
                Details = "Includes item selection, active shopping cart state management, total checkout calculation, dynamic receipt generation, and feature branch Git development.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Retro+Bytes+POS",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 14,
                Title = "Lesson: Authentication, Authorization, DTOs & UI in MVC",
                Description = "Security and architecture reference implementing authentication, authorization policies, and Data Transfer Objects (DTOs).",
                Details = "Demonstrates clean separation of concern patterns using DTOs, secure cookie-based session state, route access guards, and styled Razor views.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_MIDTERM_Q3_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Auth+and+DTOs+in+MVC",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 15,
                Title = "Help Desk Management System (EF Core Database-First)",
                Description = "Enterprise ticketing system constructed using Entity Framework Core Database-First approach.",
                Details = "Features database schema mappings, support ticket creation, status management, administrative access controls, and relationship configuration.",
                GithubUrl = "https://github.com/CABARDOJAELLANDREI/IT_ELECTIVE_PREFINALS_PROJECT.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Help+Desk+System",
                Comments = new List<CommentModel>()
            },
            new Project
            {
                Id = 16,
                Title = "PREFINALS EXAM - Quiz Application",
                Description = "ASP.NET Core MVC examination portfolio application built with monochrome UI controls.",
                Details = "Implements custom question routing, strongly-typed quiz submission handlers, dynamic scoring, and high-contrast dark/monochrome layout views.",
                GithubUrl = "https://github.com/GOMEZANGELICAMARIE/IT_ELECTIVE_2_BSIT31E2_PREFINAL_EXAM_Gomez_Angelica.git",
                ThumbnailUrl = "https://via.placeholder.com/300x180/000000/FFFFFF?text=Prefinals+Exam+App",
                Comments = new List<CommentModel>()
            }
        };
    }
}