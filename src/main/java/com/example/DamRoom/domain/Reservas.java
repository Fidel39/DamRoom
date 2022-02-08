package com.example.DamRoom.domain;


import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;


@Data
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



   @ManyToOne(fetch=FetchType.LAZY)
    private Cliente cliente;

    @OneToMany(mappedBy = "reserva", cascade = CascadeType.ALL)
    private List<Habitacion> habitacionList = new ArrayList<>();


    public Reservas(){
        fechaIni = null;
        fechaFin = null;
        this.importe = 0f;
    }

    public Reservas(Date FechaIni, Date FechaFin, Float importe, String estado,Cliente cliente/*Habitacion habitacion*/) {
        this.fechaIni = FechaIni;
        this.fechaFin = FechaFin;
        this.importe = importe;
        this.estado = estado;
        //this.habitacionList.add(habitacion);
        this.cliente = cliente;
    }


    public Reservas(Reservas reservas) {
        this.fechaIni = reservas.getFechaIni();
        this.fechaFin = reservas.getFechaFin();
        this.importe = reservas.getImporte();
        this.estado = reservas.getEstado();
        //this.habitacionList=reservas.getHabitacionList();
       this.cliente = reservas.getCliente();
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

    public List<Habitacion> getHabitacionList() {
        return habitacionList;
    }

    public void setHabitacionList(List<Habitacion> habitacionList) {
        this.habitacionList = habitacionList;
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
