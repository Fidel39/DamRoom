package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.exception.ReservaNotFoundException;
import com.example.DamRoom.repository.ClienteRepository;
import com.example.DamRoom.repository.HabitacionRepository;
import com.example.DamRoom.repository.ReservaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;
import java.util.Optional;

@Service
@Transactional
public class ReservaServiceImpl implements ReservaService{

    @Autowired
    private ReservaRepository reservaRepository;

    @Override
    public Set<Reservas> findAll() {
        return reservaRepository.findAll();
    }


    @Override
    public Set<Reservas> findReservaByfechaIni(Date fechaIni){
        return reservaRepository.findReservaByfechaIni(fechaIni);
    }

    @Override
    public Set<Reservas> findReservaByfechaFin(Date fechaFin){
        return reservaRepository.findReservaByfechaFin(fechaFin);
    }

    @Override
    public Set<Reservas> findReservaByimporte(float importe){
        return reservaRepository.findReservaByimporte(importe);
    }

    @Override
    public Set<Reservas> findReservasByestado(String estado) {
        return reservaRepository.findReservaByestado(estado);
    }

    @Override
    public Set<Reservas> estadisticaReservasAnuales(String anyo) {
        String fechaInicial = anyo+"-01-01";
        String fechaFinal = anyo+"-12-31";
        SimpleDateFormat formato = new SimpleDateFormat("yyyy-MM-dd");
        Set<Reservas> reservas = reservaRepository.findAll();
        Set<Reservas> reservasAnuales = new HashSet<>();
        try {
            Date fechaIni = formato.parse(fechaInicial);
            Date fechaFin = formato.parse(fechaFinal);

            for(Reservas re1 : reservas){
                if(re1.getFechaIni().compareTo(fechaIni) >= 0 && re1.getFechaFin().compareTo(fechaFin) <= 0){
                    reservasAnuales.add(re1);
                }
            }

        } catch (ParseException e) {
            e.printStackTrace();
        }
        return reservasAnuales;
    }


    @Override
    public Optional<Reservas> findReservaByidReserva(long idReserva){
        return reservaRepository.findReservaByidReserva(idReserva);
    }


    @Override
    public Set<Reservas> findReservaBydniCliente(String dniCliente) {
        Set<Reservas> reservas = reservaRepository.findAll();
        Set<Reservas> reservasFinal = new HashSet<>();

        for(Reservas re1 : reservas){
            if(re1.getCliente().getDni().equals(dniCliente)){
                reservasFinal.add(re1);
            }
        }

        return reservasFinal;
    }


    @Override
    public Reservas addReserva(Reservas reservas){
        return reservaRepository.save(reservas);
    }

    @Override
    public Reservas modifyReserva(long idReserva, Reservas newReserva){
        Reservas reservas = reservaRepository.findReservaByidReserva(idReserva)
                .orElseThrow(() -> new ReservaNotFoundException(idReserva));
        newReserva.setIdReserva(reservas.getIdReserva());
        return reservaRepository.save(newReserva);
    }

    @Override
    public void deleteReserva(long idReserva) {
        Reservas reservas = reservaRepository.findReservaByidReserva(idReserva)
                .orElseThrow(() -> new ReservaNotFoundException(idReserva));
        reservaRepository.delete(reservas);
    }

    @Override
    public Reservas checkReserva(String check,Reservas reservas1) {
        Reservas reservas = reservaRepository.findReservaByidReserva(reservas1.getIdReserva())
                .orElseThrow(() -> new ReservaNotFoundException(reservas1.getIdReserva()));

        if(reservas.getEstado().equals("Pendiente")&&check.equals("CheckIn")){
            reservas.setEstado("En Activo");
        }else if(reservas.getEstado().equals("En Activo")&&check.equals("CheckOut")){
            reservas.setEstado("Finalizado");
        }
        Long id = reservas.getIdReserva();
        return reservas;
    }
}
