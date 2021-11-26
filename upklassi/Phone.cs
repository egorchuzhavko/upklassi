using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Phone
    {
        private string number;
        private string model;
        private double weight;

        public Phone() {}

        public Phone(string number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public override string ToString() { return $"Телефон: {number} \nМодель: {model}\nВес: {weight}"; }
        public string receiveCall(string name) { return $"Звонит {name}"; }
        public string receiveCall(string name, string number) { return $"Звонит {name}, номер: {number}"; }
        public string getNumber() { return $"Телефон: {number}"; }
        public void sendMessage(string message, params string[] numbers)
        {
            Console.WriteLine($"Сообщение: {message}\nБудет отправлено на номера:\n{string.Join<string>("\n", numbers)}");
        }
    }
}
