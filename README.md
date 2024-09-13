The "Empowering University Student Complaint Cell" (SCC) project is a comprehensive digital complaint management system designed to streamline and improve the process of handling student
complaints in a university setting. The system consists of two key applications: an Android app for students to submit complaints, and a desktop application for administrators to manage and
resolve them. 

The desktop application assigns role-based access to four types of admins—SSO, Registrar, Vice-Chancellor (VC), and President—each with specific responsibilities. If a personal or simple 
complaint is not addressed within three days by the assigned admin, the system automatically forwards the complaint to the next higher-level admin. For university-wide issues, a voting 
mechanism is implemented. When a student submits a voting-based complaint, other students can vote on it. Based on vote thresholds (30%, 60%, 90%), the complaint escalates through the roles
from SSO to Registrar, VC, and finally to the President.

Additionally, an AI module integrated into the system filters out and deletes irrelevant complaints. Once complaints are fetched from the Firebase database, the AI automatically identifies
and removes complaints deemed unnecessary, ensuring the system stays efficient and relevant to student concerns.
