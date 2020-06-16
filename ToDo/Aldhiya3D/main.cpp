#include <GL/glut.h>
#include <math.h>

void cylinder(float rbase,float rtop,float height);
void blok(float tebal,int ratiol,int ratiop);


int screen_width=800;
int screen_height=600;
int button_up=0,button_down=0;
int Turn=0;

double rotation_y=0,rotation_y_plus=-15,direction;
double Rhead=0,Rheadplus=0;
double rotate_All=0,All_plus=0;
double Angguk=0,Anggukplus=0;
double press=0,pressplus,pressplus1=180,pressplus2=0,pressplus3=0,pressplus4=0,pressplus5=0;



GLfloat ambient_light[]={0.0,0.0,0.45,1.0};
GLfloat  source_light[]={0.8,0.8,0.8,1.0};
GLfloat    light_pos[]={5.0,0.0,6.0,1.0};

void init(void)
{
 glClearColor(1.0,1.0,1.0,0.0);  //putih    //glClearColor(0.0,0.0,0.4,0.0); //back color
 glShadeModel(GL_SMOOTH);
 glViewport(0,0,screen_width,screen_height);
 glMatrixMode(GL_PROJECTION);
 glLoadIdentity();
 gluPerspective(45.0f,(GLfloat)screen_width/(GLfloat)screen_height,1.0f,1000.0f);

 glEnable  (GL_DEPTH_TEST);
 glPolygonMode   (GL_FRONT_AND_BACK,GL_FILL);
 glEnable  (GL_LIGHTING);
 glLightModelfv  (GL_LIGHT_MODEL_AMBIENT,ambient_light);
 glLightfv  (GL_LIGHT0,GL_DIFFUSE,source_light);
 glLightfv  (GL_LIGHT0,GL_POSITION,light_pos);
 glEnable  (GL_LIGHT0);
 glEnable  (GL_COLOR_MATERIAL);
 glColorMaterial (GL_FRONT,GL_AMBIENT_AND_DIFFUSE);
}

void resize(int width,int height)
{
 screen_width=width;
 screen_height=height;

 glClear(GL_COLOR_BUFFER_BIT|GL_DEPTH_BUFFER_BIT);
 glViewport(0,0,screen_width,screen_height);
 glMatrixMode(GL_PROJECTION);
 glLoadIdentity();
 gluPerspective(45.0f,(GLfloat)screen_width/(GLfloat)screen_height,1.0f,1000.0f);

 glutPostRedisplay();
}

void display(void)
{
 glClear(GL_COLOR_BUFFER_BIT|GL_DEPTH_BUFFER_BIT);
 glMatrixMode(GL_MODELVIEW);
 glLoadIdentity();

 glTranslatef(-6,3,-70);//atur posisi benda semua
 glPushMatrix();


       Rhead=Rhead+Rheadplus; /* jika cut gambar diam*/

      glRotatef(Rhead,1.0,0.0,1.0);//merubah translasi,rotsi keseluruhan kalo di nokan semua menjadi scaling
    Rheadplus=3;//untuk kecepatan rotasi
        //end turn left-right for fan head

    glTranslatef(0.0,0,0);// untuk pergereakan rotasi
    //cylinder(3,3,6); /* jika cut silinder 2 off */

   glRotatef(0,0,0.0,0.0);
      glTranslatef(0,0,5); // penggabungan obyek
   cylinder(1.9,5,3); // ukuran obyek // jika cut silinder 1 off


   glRotatef(45,1.0,0.0,0.0);
   glTranslatef(0,-1.5,5);// untuk pergereakan rotasi
   blok(0.7,3,6);

   glRotatef(45,1.0,0.0,0.0);
   glTranslatef(0,2.7,2.8);// untuk pergereakan rotasi
   blok(0.7,3,26);


    glRotatef(120,0.0,1.0,0.0);
   glPopMatrix();
   glRotatef(360,0.0,0.0,1.0);
   glTranslatef(0.0,1.0,0);
 glFlush();
 glutSwapBuffers();

}


void cylinder(float rbase,float rtop,float height)
{
 float i;
 glPushMatrix();
 glTranslatef(0.0,0.0,-rbase/4);
 glutSolidCone(rbase,0,32,9);//0 nya buat kerucut,32 nya untuk nutup lubang, 0 nya untuk mlubangi dan membuat jadi tembus (bagian atas)

 for(i=0;i<=height;i+=rbase/8)
 {
  glTranslatef(0.0,0.0,rbase/8);
  glutSolidTorus(rbase/4,rbase-((i*(rbase-rtop))/height),16,16);
 }
 glTranslatef(0.0,0.0,rbase/4);
 glutSolidCone(rtop,0,1,0);//0 nya buat kerucut(jika semua bukan nol),32 nya untuk nutup lubang, 0 nya untuk mlubangi dan membuat jadi tembus ( bagian bawah )
 glPopMatrix();
}

void blok(float tebal,int ratiol,int ratiop)
{
 float i,j;
 glPushMatrix();
 for(i=0;i<ratiop;i++)
 {
  glTranslatef(-(ratiol+1)*tebal/2,0.0,0.0);
  for(j=0;j<ratiol;j++)
  {
   glTranslatef(tebal,0.0,0.0);
   glutSolidCube(tebal);
  }
  glTranslatef(-(ratiol-1)*tebal/2,0.0,tebal);
 }
 glPopMatrix();
}

int main(int argc,char **argv)
{
 glutInit(&argc,argv);
 glutInitDisplayMode(GLUT_DOUBLE|GLUT_RGB|GLUT_DEPTH);
 glutInitWindowSize(screen_width,screen_height);
 glutInitWindowPosition(0,0);
 glutCreateWindow("");
 glutDisplayFunc(display);
 glutIdleFunc(display);
 glutReshapeFunc(resize);
 init();
 glutMainLoop();
 return(0);
}
