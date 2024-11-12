using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGameApp
{
    public class SnakeGameForm : Form
    {
        const int TileSize = 20;
        const int GridWidth = 20;
        const int GridHeight = 10;

        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        List<PictureBox> snakebody = new List<PictureBox>();
        PictureBox food = new PictureBox();
        Random random = new Random();
        int score = 0;

        private enum Direction { Up, Down, Left, Right }
        private Direction currentDirection = Direction.Right;

        public SnakeGameForm()
        {
            this.Text = "Jogo da Cobrinha - Snake Game v 0.0.3";
            this.Size = new Size(GridWidth * TileSize, GridHeight * TileSize);
            this.StartPosition = FormStartPosition.CenterScreen;

            gameTimer.Interval = 200;
            gameTimer.Tick += GameLoop;

            // Evento para detectar as teclas de direção
            this.KeyDown += new KeyEventHandler(OnKeyDown);

            // Configuração inicial da cabeça da cobra
            var head = new PictureBox()
            {
                BackColor = Color.Green,
                Size = new Size(TileSize, TileSize),
                Location = new Point(TileSize * 5, TileSize * 5),
            };

            snakebody.Add(head);
            this.Controls.Add(head);

            // Configuração inicial da comida
            food.Size = new Size(TileSize, TileSize);
            food.BackColor = Color.Red;
            this.Controls.Add(food);
            SpawnFood();

            gameTimer.Start();
        }

        void SpawnFood()
        {
            food.Location = new Point(random.Next(0, GridWidth) * TileSize, random.Next(0, GridHeight) * TileSize);
        }

        void GameLoop(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollisions();
        }

        void MoveSnake()
        {
            // Obtém a posição atual da cabeça da cobra
            var head = snakebody[0];
            Point newHeadLocation;

            // Define a nova posição da cabeça com base na direção atual
            switch (currentDirection)
            {
                case Direction.Up:
                    newHeadLocation = new Point(head.Location.X, head.Location.Y - TileSize);
                    break;
                case Direction.Down:
                    newHeadLocation = new Point(head.Location.X, head.Location.Y + TileSize);
                    break;
                case Direction.Left:
                    newHeadLocation = new Point(head.Location.X - TileSize, head.Location.Y);
                    break;
                case Direction.Right:
                    newHeadLocation = new Point(head.Location.X + TileSize, head.Location.Y);
                    break;
                default:
                    newHeadLocation = head.Location;
                    break;
            }

            // Atualiza a posição da cabeça e move o resto do corpo
            for (int i = snakebody.Count - 1; i > 0; i--)
            {
                snakebody[i].Location = snakebody[i - 1].Location;
            }
            snakebody[0].Location = newHeadLocation;
        }

        void CheckCollisions()
        {
            // Verificar se a cobra colidiu com a comida
            if (snakebody[0].Bounds.IntersectsWith(food.Bounds))
            {
                score += 10;
                SpawnFood();
                GrowSnake();
            }

            // Verificar colisão com as bordas do campo
            var headLocation = snakebody[0].Location;
            if (headLocation.X < 0 || headLocation.Y < 0 || headLocation.X >= GridWidth * TileSize || headLocation.Y >= GridHeight * TileSize)
            {
                GameOver();
            }

            // Verificar colisão com o próprio corpo
            for (int i = 1; i < snakebody.Count; i++)
            {
                if (snakebody[0].Bounds.IntersectsWith(snakebody[i].Bounds))
                {
                    GameOver();
                }
            }
        }

        void GrowSnake()
        {
            var newPart = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                BackColor = Color.Green
            };

            snakebody.Add(newPart);
            this.Controls.Add(newPart);
        }

        void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Define a direção da cobra com base na tecla pressionada
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentDirection != Direction.Down) // Impede mover na direção oposta
                        currentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
            }
        }

        void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show("Game Over! Pontuação: " + score);
            Application.Exit();
        }
    }
}
