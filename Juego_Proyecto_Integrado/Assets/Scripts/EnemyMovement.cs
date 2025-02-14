using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;
using static Unity.VisualScripting.Round<TInput, TOutput>;
using UnityEngine.Device;

public class EnemyMovement : MonoBehaviour
{
  

    def move_random(self):
        self.x += random.choice([-self.speed, 0, self.speed])
        self.y += random.choice([-self.speed, 0, self.speed])

# Mantener al enemigo dentro de la pantalla
        self.x = max(0, min(WIDTH - self.width, self.x))
        self.y = max(0, min(HEIGHT - self.height, self.y))

    def draw(self, screen):
        pygame.draw.rect(screen, RED, (self.x, self.y, self.width, self.height))

# Instancia del enemigo
enemy = Enemy()

# Bucle principal
running = True
clock = pygame.time.Clock()
while running:
    screen.fill(BLACK)
    
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    enemy.move_random()
    enemy.draw(screen)


    pygame.display.flip()
    clock.tick(10)  # Controlar la velocidad del movimiento

pygame.quit()

}

}
