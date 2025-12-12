using System;
using System.Collections;


namespace projectCourse;


class Cars
{
    // Handler Обычно дописывают, чтобы показать, что делегат связан с событием
    public delegate void HealtheHandler(int health);

    // event Это специальный тип данных, для создания события
    // event / то на чем будет основано событие / название события
    public event HealtheHandler? ActionHealth;

    private int health;

    public Cars()
    { 
        // Этот консутруктор говорить, что при создании объекта жизни будут всегда на 100
        this.health = 100;
        
    }

    public void Heal(int heal)
    {
        this.health += heal;
        // Правильный метод для вызова события и передачи в него значения
        ActionHealth?.Invoke(this.health);
    }

    public void Damage(int damage)
    {
        this.health -= damage;
        ActionHealth?.Invoke(this.health);
    }

}

