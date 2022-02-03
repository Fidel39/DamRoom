package com.example.DamRoom.exception;

public class ReservaNotFoundException extends RuntimeException{
    public ReservaNotFoundException(){
        super();
    }

    public ReservaNotFoundException(String message){
        super(message);
    }

    public ReservaNotFoundException(long codReserva){
        super("Reserva not found: " + codReserva);
    }
}
