## Kindra Bilodeau
#### SQL Homework 10

1. **What is the purpose of transactions? Why do we use transactions in SQL scripts?**
  - A unit of work that is atomic, that queries and modifies data.
2. **Briefly describe each of the ACID properties.**
  - atomicity: an atomic unit of work, cant be subdivided
  - Consistency: refers to the state of the data
  - isolation: ensure that transactions access only consistent data
  - durability: Useable. permanent

3. **What do we mean when we talk about the granularity of locks?**
  - How much data is locked. a small amount (fine) or a large of amount (course)
4. **What do we mean when we talk about the modes of locks?**
  - Different level of locks
5. **In your own words, describe blocking, and give an example.**
  - Stopping a transaction from happening. If two transactions try to occur at the same time, one will be blocked
6. **What are the properties of locks? That is, list the column name and column type of the fields in
sys.dm tran locks.**
  - request_session_id
  - resource_type
  - resource_database_id
  - DB_Name
  - resource_description
  - resource_associated_entity_id
  - request_mode
  - request_status
7. **What are the properties of sessions? That is, list the column name and column type of the fields in
sys.dm exec connections.**
  - request_session_id
  - connect_time
  - last_read
  - last_write
  - most_recent_sql_handle
8. **What are the requests of sessions? That is, list the column name and column type of the fields in
sys.dm exec requests.**
  - request_session_id
  - blocking_session_id
  - command
  - sql_handle
  - database_id
  - wait_type
  - wait_time
  - wait_resource
9. **What is an isolation level? Give an example of the operation of an isolation level.**
  - Determines the level of consistency you get when you interact with data
10. **(Not in the book.) What do we mean when we say that an object is serializable?**
  - make it linear for storing 
11. **What is an deadlock? Give an example of a deadlock?**
  - where two or more sessions block each other
