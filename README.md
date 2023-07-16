# Library Information System

This project was developed as part of a System Analysis and Design course, based on a real school's library manual managment processes.

## Functionality

The project implements the following CRUD operations for the following entities:

1. Student
2. Teacher
3. Librarian
4. Book

## Use Cases

The system addresses the following use cases:

1. Take part in book socialization media:
   - Students can rate books on a scale of 1-5.
   - Students can view their own or their friends' social pages.
   - Students can join predetermined book clubs created by the school.

2. Track reading progress:
   - Students can set yearly reading goals.
   - Students can view their borrowing history.
   - The system generates visual reports of students' reading goals.

3. Handle time extension requests:
   - Students can request a time extension for books they haven't returned.
   - Automatic approval of extension requests based on book availability and waitlist.
   - Librarians can accept or decline extension requests.

4. Handle alternative book submissions:
   - Students can request a replacement book for damaged books in their possession.
   - Librarians can approve or decline replacement requests.

5. Events at the library:
   - Teachers can post events happening at the library.
   - Students can register for upcoming events.
   - Students can leave reviews after the event.
   - Students receive notifications if an event's date changes.

## Security

All user passwords are MD5 hash encrypted for enhanced security.

