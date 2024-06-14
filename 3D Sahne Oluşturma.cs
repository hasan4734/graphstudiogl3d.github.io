
public MainForm()
{
 //Döngüyü Başlatma
  Run.Start();
//Render Oluşturma
  Renderer rederer = new Renderer(800,600);

//Camera Oluşturma
 camera = new Camera();
 camera.Position = new Vector3(0, 0, 5);
 camera.Target = new Vector3(0, 0, 0);
 camera.Up = new Vector3(1, 0, 0);
}
//Render Döngüsü
 void RunTick(object sender, EventArgs e)
  {
    	gl.Clear(Color.Black);
			pictureBox1.Image =gl.Render(Cubemat);
  }
