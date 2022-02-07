package com.example.DamRoom.domain;

import java.io.Serializable;
import java.util.Objects;

public class ReservasId implements Serializable {

    private static final long serialVersionUID = 1L;

    private String DNICliente;
    private Long numHabitacion;

    public ReservasId() {

    }

    public ReservasId(String DNICliente, Long numHabitacion) {
        this.DNICliente = DNICliente;
        this.numHabitacion = numHabitacion;
    }

    public String getDNICliente() {
        return DNICliente;
    }

    public void setDNICliente(String DNICliente) {
        this.DNICliente = DNICliente;
    }

    public Long getNumHabitacion() {
        return numHabitacion;
    }

    public void setNumHabitacion(Long numHabitacion) {
        this.numHabitacion = numHabitacion;
    }

}
