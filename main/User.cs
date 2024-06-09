using System;
using System.Collections.Generic;
using System.Text;

namespace az_payegahDadeh
{
    public class User
    {
     
     private String name;
     private String last_name;
     private String email;
     private String username;
     private String password;
     private int id;

     public User(String name , String last_name,String email, String username, String password )
        {
            setName(name);
            setLast_name(last_name);
            setEmail(email);
            setUsername(username);
            setPassword(password);
            /*setId(id);*/

        }
        public User()
        {
            setName("test");
            setLast_name("test");
            setEmail("test");
            setUsername("test");
            setPassword("test");
           /* setId(1);*/
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
  
        public void setLast_name(String last_name)
        {
            this.last_name = last_name;
        }
        public String getLast_name()
        {
            return this.last_name;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return this.email;
        }
        public void setUsername(String username)
        {
            this.username = username;
        }
        public String getUsername()
        {
            return this.username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }
        public String getPassword()
        {
            return this.password;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public String toString()
        {
            return getName()+" " + getLast_name() + " " + getEmail()+" "+ getUsername() + " " + getPassword() + " " + getId();   
        }




    }
}
