public MainForm()
{
 //Döngüyü Başlatma
  Run.Start();
//Render Oluşturma
  Renderer renderer = new Renderer(800,600);

//Camera Oluşturma
 camera = new Camera();
 camera.Position = new Vector3(0, 0, 5);
 camera.Target = new Vector3(0, 0, 0);
 camera.Up = new Vector3(1, 0, 0);
 
 //Light Ekleme
Light light = new Light(new Vector3(0, 0 , 10), Color.LightYellow,d,0.8, 5, 1000);
renderer.SetLight(light);

//Küp Ve Material Oluşturma
 Material Cubemat = new Material(Color.LightSkyBlue,10,DifusseTexture,BumpTexture);
 Cube cube = new Cube(new Vector3(0, 0, 0), 1);
 cube.Material = Cubemat;
 cube.Material.Shininess=0.1f;
 cube.Name ="Cube";
}
//Render Döngüsü
 void RunTick(object sender, EventArgs e)
  {
    	gl.Clear(Color.Black);
      //Küpü Çizme
      cube.Draw(renderer,camera);
      //Küpe Animasyon Ekleme
      cube.RotateX(0.07);
      cube.RotateY(0.07);
      cube.RotateZ(0.07);

			pictureBox1.Image =gl.Render(Cubemat);
  }
