public void button1_Click(object sender, EventArgs e)  
{  
   SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
   SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='"+ textBox1.Text +"' AND password='"+ textBox2.Text +"'",con);  
        /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */  
   DataTable dt = new DataTable(); //this is creating a virtual table  
   sda.Fill(dt);  
   if (dt.Rows[0][0].ToString() == "1")  
   {  
      /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */   
      this.Hide();  
      new home().Show();  
   }  
   else  
   MessageBox.Show("Invalid username or password");  
  
}  