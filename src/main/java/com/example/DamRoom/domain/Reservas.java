package com.example.DamRoom.domain;


import com.fasterxml.jackson.annotation.*;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;
import java.util.Set;


@Entity
@Table(name = "reservas")
public class Reservas {

    @Schema(description = "Identificador de la habitacion", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long idReserva;



    @Schema(description = "Fecha de inicio de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaIni;


    @Schema(description = "Fecha de finalizacion de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaFin;

    @Schema(description = "Precio  de la reserva", example = "450€",
            required = true)
    @NotBlank
    @Column
    private Float importe;

    @Schema(description = "Estado de la reserva", example = "Libre,Reservado,Pendiente", required = true)
    @NotBlank
    @Column
    private String estado;

    @Schema(description = "DNI del cliente de la reserva", example = "4956321C", required = true)
    @NotBlank
    @Column
    private String dniCliente;

    @ManyToOne
    private Cliente cliente;


    @OneToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "Habitacion")
    private Habitacion habitacion;


    public Reservas(){
        fechaIni = null;
        fechaFin = null;
        this.importe = 0f;
        this.estado = "En Pendiente";
        this.dniCliente="";
    }

    public Reservas(String estado,Date FechaIni, Date FechaFin, Float importe, Cliente cliente,Habitacion habitacion,String dniCliente) {
        this.fechaIni = FechaIni;
        this.fechaFin = FechaFin;
        this.importe = importe;
        this.estado = estado;
        this.habitacion=habitacion;
        this.cliente = cliente;
        this.dniCliente = dniCliente;
    }


   public Reservas(Reservas reservas) {
        this.fechaIni = reservas.getFechaIni();
        this.fechaFin = reservas.getFechaFin();
        this.importe = reservas.getImporte();
        this.estado = "En Pendiente";
        this.habitacion= reservas.getHabitacion();
       this.cliente = reservas.getCliente();
       this.dniCliente=reservas.getCliente().getDni();
    }


    public Date getFechaIni() {
        return fechaIni;
    }

    public void setFechaIni(Date FechaIni) {
        this.fechaIni = FechaIni;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date FechaFin) {
        this.fechaFin = FechaFin;
    }

    public Float getImporte() {
        return importe;
    }

    public void setImporte(Float importe) {
        this.importe = importe;
    }

    public Long getIdReserva() {
        return idReserva;
    }

    public void setIdReserva(Long idReserva) {
        this.idReserva = idReserva;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public String getDniCliente() {
        return dniCliente;
    }

    public void setDniCliente(String dniCliente) {
        this.dniCliente = dniCliente;
    }

    public Habitacion getHabitacion() {
        return habitacion;
    }

    public void setHabitacion(Habitacion habitacion) {
        this.habitacion = habitacion;
    }

    @Override
    public String toString() {
        return "Reservas{" +
                ", FechaIni=" + fechaIni +
                ", FechaFin=" + fechaFin +
                ", importe=" + importe +
                '}';
    }
}
