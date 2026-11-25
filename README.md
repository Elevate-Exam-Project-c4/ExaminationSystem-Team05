# Examination System — Team 05

## V4.4 backend starter template

This is the same intentionally empty starter template distributed to all five teams.
Use the approved V4.4 business specification as the source of requirements. No
feature implementation, entity definitions, migrations or database seed data are provided.

- .NET 10 / ASP.NET Core
- Modular monolith, Vertical Slice Architecture and CQRS
- EF Core with SQL Server only
- Original project namespace: `exam_system`

## Getting started

1. Open `exam system.slnx` or `exam system.csproj` using a .NET 10-compatible IDE.
2. Restore the NuGet packages and build the project.
3. Implement the shared foundation and entities according to the approved requirements.
4. Configure your own development SQL Server connection securely. Both connection
   string placeholders are empty intentionally; never commit real credentials.
5. Implement and register the persistence layer, authentication and other required
   dependencies. Create your own migrations only after implementing the model.

The host bootstrap in `Program.cs` contains only basic framework setup. It does
not register a DbContext, access a database, create an admin or seed data. The
`AppDbContext`, repository, unit of work, shared response types and seed/DI types
are empty shells. Enums and entity definitions are left to the team.
There are no implemented API endpoints.

## Folder conventions

```
Common/
Domain/
  Common/
  Entities/
    Identity/
    Diplomas/
    Quizzes/
    Attempts/
Features/
  Identity/
  Diplomas/
  Quizzes/
  Attempts/
  Analytics/
  Shared/
Persistence/
  Configurations/
  Context/
  DataAccess/
```

Each business feature folder contains empty subfolders with `.gitkeep` markers.
Add the classes required for your feature when implementing it; the folder layout
does not imply that every feature needs all the listed CQRS components.
`Features/Shared` contains only empty common response-type declarations, not
business features. `.gitkeep` is a conventional Git placeholder, not executable code.

## V4.4 story-to-folder index

The 33 stories are represented by the following starter folders. Related CRUD
actions may use separate slices while remaining under one Jira story.
This index is for navigation only; it does not replace the requirements.

| Story | Business responsibility | Starter folders |
|---|---|---|
| EXAM-1 | User Registration | `Features/Identity/` — `Register` |
| EXAM-2 | Verify Email (OTP) | `Features/Identity/` — `VerifyEmailOtp` |
| EXAM-3 | Resend Verification OTP | `Features/Identity/` — `ResendVerificationOtp` |
| EXAM-4 | Login | `Features/Identity/` — `Login` |
| EXAM-5 | Refresh Access Token & Logout | `Features/Identity/` — `RefreshToken`, `Logout` |
| EXAM-6 | Forgot Password (OTP-based reset) | `Features/Identity/` — `ForgotPassword` |
| EXAM-8 | Role-Based Access Control | `Features/Identity/` — `RoleBasedAccessControl` |
| EXAM-9 | Browse Diplomas (Student) | `Features/Diplomas/` — `BrowseDiplomas` |
| EXAM-10 | View Diploma Detail & Quizzes | `Features/Diplomas/` — `GetDiplomaDetail` |
| EXAM-11 | Student Dashboard | `Features/Diplomas/` — `GetStudentDashboard` |
| EXAM-12 | Enroll in a Diploma | `Features/Diplomas/` — `EnrollDiploma` |
| EXAM-13 | Diploma Content Management (Admin) | `Features/Diplomas/` — `AdminCreateDiploma`, `AdminUpdateDiploma`, `AdminDeleteDiploma`, `AdminBrowseDiplomas`, `AdminGetDiplomaDetail` |
| EXAM-14 | Quiz Management (Admin) | `Features/Quizzes/` — `AdminCreateQuiz`, `AdminUpdateQuiz`, `AdminBrowseQuizzes`, `AdminGetQuizDetail` |
| EXAM-15 | Reusable Question Bank Management (Admin) | `Features/Quizzes/` — `AdminManageQuestions` |
| EXAM-28 | Reusable Options Bank Management (Admin) | `Features/Quizzes/` — `AdminManageOptions` |
| EXAM-29 | Question-Option Configuration (Admin) | `Features/Quizzes/` — `AdminConfigureQuestionOptions` |
| EXAM-31 | Quiz-Question Configuration (Admin) | `Features/Quizzes/` — `AdminConfigureQuizQuestions` |
| EXAM-16 | Quiz Pre-Publish Validation | `Features/Quizzes/` — `AdminQuizPublishCheck` |
| EXAM-17 | Publish / Unpublish Quiz | `Features/Quizzes/` — `AdminPublishQuiz`, `AdminUnpublishQuiz` |
| EXAM-18 | Delete Quiz (Admin) | `Features/Quizzes/` — `AdminDeleteQuiz` |
| EXAM-19 | Start Quiz Attempt | `Features/Attempts/` — `StartAttempt` |
| EXAM-33 | Resume Quiz Attempt | `Features/Attempts/` — `ResumeAttempt` |
| EXAM-20 | Answer Question | `Features/Attempts/` — `AnswerQuestion` |
| EXAM-32 | Navigate Quiz Questions | `Features/Attempts/` — `NavigateQuizQuestions` |
| EXAM-21 | Automatic Submission & Recovery | `Features/Attempts/` — `AutomaticSubmissionAndRecovery` |
| EXAM-34 | Review Attempt | `Features/Attempts/` — `ReviewAttempt` |
| EXAM-22 | Submit & Score Attempt | `Features/Attempts/` — `SubmitAttempt` |
| EXAM-23 | View Attempt Results | `Features/Attempts/` — `GetAttemptResults` |
| EXAM-24 | My Attempt History | `Features/Attempts/` — `GetAttemptHistory` |
| EXAM-25 | Admin Dashboard | `Features/Analytics/` — `GetAdminDashboard` |
| EXAM-26 | Quiz Performance Analytics | `Features/Analytics/` — `GetQuizPerformanceAnalytics` |
| EXAM-30 | Student Performance Analytics | `Features/Analytics/` — `GetStudentPerformanceAnalytics` |
| EXAM-27 | Attempt Monitoring | `Features/Analytics/` — `SearchAttempts`, `GetAdminAttemptDetail` |

## Submission notes

- Do not reintroduce the removed Check Remaining Time feature.
- Follow the current business specification for separate Start, Resume, Answer,
  Navigation, Review and Submit responsibilities.
- The periodic recovery mechanism is optional as stated in V4.4.
- Keep your own Git history; the supplied source history has been removed.
