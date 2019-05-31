using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerlinNoisePlayGround
{
    public partial class Form1 : Form
    {
      
        

        public double offsetX;
        public double offsetY;
        //random number
        Random rand = new Random((int)DateTime.Now.Ticks);



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate();
        }
        public void generate()
        {
            int height = 513;
            int width = 513;

            float scale = 100f;
            int seed = rand.Next();
            int octaves = 10;
            float persistance = 0.5f;
            float lacunarity = 1.87f;


            float[,] map = new float[height, width];
            map =      GetPerlin(map, height, width, scale, seed, octaves, persistance, lacunarity);
            float[,] map2 = new float[height, width];
            map2 = GenerateNoise(map2, height, width, scale, seed, octaves, persistance, lacunarity);//GetPerlin(height,width,10,0.5,1.87);

            //map2 = RoundPerlinValues(map2, height, width);
            //ToScreen(map2, height, width);

            map = RoundPerlinValues(map, height, width);
            ToScreen(map, height, width);
        }



        public void ToScreen(float[,] map, int height, int width)
        {
            //bitmap
            Bitmap bmp = new Bitmap(width, height);

            //create random pixels
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (map[x, y] == 7)
                    {
                        bmp.SetPixel(x, y, Color.White);
                    }
                    else if(map[x, y] == 6)
                    {
                        bmp.SetPixel(x, y, Color.DarkGray);
                    }
                    else if(map[x, y] == 5)
                    {
                        bmp.SetPixel(x, y, Color.Gray);
                    }
                    else if(map[x, y] == 4)
                    {
                        bmp.SetPixel(x, y, Color.DarkGreen);
                    }
                    else if(map[x, y] == 3)
                    {
                        bmp.SetPixel(x, y, Color.LightGreen);
                    }
                    else if(map[x, y] == 2)
                    {
                        bmp.SetPixel(x, y, Color.LightYellow);
                    }
                    else if (map[x, y] == 1)
                    {
                        bmp.SetPixel(x, y, Color.LightBlue);
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.DarkBlue);
                    }
                }
            }

            //load bmp in picturebox1
            pictureBox1.Image = bmp;
        }


        public float[,] RoundPerlinValues(float[,] map,int height, int width)
        {
            /*
             * value order
             * 0 = deep water
             * 1 = water
             * 2 = beach
             * 3 = plains
             * 4 = forrest
             * 5 = mountain 1
             * 6 = mountain 2
             * 7 = snow
             */
            double deepwater = 0.05;
            double water = 0.1;
            double beach = 0.15;
            double plains = 0.25;
            double forrest = 0.4;
            double mountain1 = 0.65;
            double mountain2 = 0.75;
            double snow = 0.85;


            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {

                    if (map[x, y] >= snow)
                    {
                        map[x, y] = 7;
                    }
                    else if(map[x, y] >= mountain2)
                    {
                        map[x, y] = 6;
                    }
                    else if(map[x, y] >= mountain1)
                    {
                        map[x, y] = 5;
                    }
                    else if(map[x, y] >= forrest)
                    {
                        map[x, y] = 4;
                    }
                    else if(map[x,y] >= plains)
                    {
                        map[x, y] = 3;
                    }
                    else if (map[x, y] >= beach)
                    {
                        map[x, y] = 2;
                    }
                    else if (map[x, y] >= water)
                    {
                        map[x, y] = 1;
                    }
                    else
                    {
                        map[x, y] = 0;
                    }

                }
            }

            return map;
        }



        public float[,] GetPerlin(float[,] map ,int height,int width,float scale,int seed, int octaves, float persistance, float lacunarity)
        {
            

            Random rand = new Random(seed);

            float offsetX = rand.Next(0, 100000);
            float offsetY = rand.Next(0, 100000);

            if (scale <= 0)
            {
                scale = 0.0001f;
            }
            float minNoiseHeight = float.MinValue;
            float maxNoiseHeight = float.MaxValue;

            Perlin perlin = new Perlin();


            for (int x = 0; x < height -1; x++)
            {
                for (int y = 0; y < width -1; y++)
                {
                    float amplitude = 1;
                    float frequency = 1;
                    float noiseHeight = 0;

                    for (int i = 0; i < octaves; i++)
                    {

                        double xCoord = (height -x) / scale * frequency + offsetX;
                        double yCoord = (width - y) / scale * frequency + offsetY;
                    
                 
                        float value = (float)perlin.perlin(xCoord, yCoord, 0) *2 -1;
                        noiseHeight += value * amplitude;

                        amplitude *= persistance;
                        frequency *= lacunarity;

                    }

                    if (noiseHeight > maxNoiseHeight)
                    {
                        maxNoiseHeight = noiseHeight;
                    }
                    else if (noiseHeight < minNoiseHeight)
                    {
                        minNoiseHeight = noiseHeight;
                    }
                    map[x, y] = noiseHeight;

                }
            }

            return map;
        }

        
        public float[,] GenerateNoise(float[,] map, int xsize, int ysize, float scale, int seed, int octaves, float persistance, float lacunarity)
        {

            Random rnd = new Random(seed);
            float offsetX = rnd.Next(0, 100000);
            float offsetY = rnd.Next(0, 100000);



            if (scale <= 0)
            {
                scale = 0.0001f;
            }
            float minNoiseHeight = float.MinValue;
            float maxNoiseHeight = float.MaxValue;

            Perlin Noise = new Perlin();

            //perlin noise
            for (int y = 0; y <= ysize - 1; y++)
            {
                for (int x = 0; x <= xsize - 1; x++)
                {
                    float amplitude = 1f;
                    float frequency = 1f;
                    float noiseHeight = 0;


                    for (int i = 0; i < octaves; i++)
                    {


                        float sampleX = (xsize - x) / scale * frequency + offsetX;
                        float sampleY = (ysize - y) / scale * frequency + offsetY;


                        float PerlinValue = (float)Noise.perlin(sampleX, sampleY, 0) * 2 - 1;
                        map[x, y] = PerlinValue;
                        noiseHeight += PerlinValue * amplitude;

                        amplitude *= persistance;
                        frequency *= lacunarity;

                        // map[x, y] = map[x, y] - fallmap[x, y];
                    }

                    if (noiseHeight > maxNoiseHeight)
                    {
                        maxNoiseHeight = noiseHeight;
                    }
                    else if (noiseHeight < minNoiseHeight)
                    {
                        minNoiseHeight = noiseHeight;
                    }
                    map[x, y] = noiseHeight;
                    // map[x, y] = map[x, y] - fallmap[x, y] ;

                }


            }


            return map;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate();
        }
    }
}
